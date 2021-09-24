from bs4.element import Comment
import request
import bs4
import re

# 请求页面
def request_page(url):

    headers = {
        "User-Agent": r"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) "
        r"Chrome/88.0.4324.150 Safari/537.36",
        "Accept-Language": "zh-CN,zh;q=0.9,en;q=0.8,en-GB;q=0.7,en-US;q=0.6",
    }

    # 发送请求
    res = request.get(url=url, headers=headers)
    res.encoding = "utf-8"

    return res


def get_api_request_data(res, class_name):

    # 处理请求
    soup = bs4.BeautifulSoup(res.text, "html.parser")

    div_part = soup.find_all("div", class_="part")

    # 查找请求参数div_part
    request_data_tr = None
    for each in div_part:
        if each.h3.text == "请求参数":
            request_data_tr = each.find("div", class_="table-wrp").table.tbody
            break

    if request_data_tr is None:
        return ""

    result = create_class(class_name, request_data_tr)
    return result


def get_api_return_json(res, class_name):

    # 处理请求
    soup = bs4.BeautifulSoup(res.text, "html.parser")

    div_part = soup.find_all("div", class_="part")

    # 查找请求参数div_part
    request_data_tr = None
    for each in div_part:
        if each.h3.text == "返回参数":
            request_data_tr = each.find("div", class_="table-wrp").table.tbody
            break

    if request_data_tr is None:
        return ""
    result = create_class(class_name, request_data_tr)
    return result


def get_api_notify_json(res, class_name):

    # 处理请求
    soup = bs4.BeautifulSoup(res.text, "html.parser")

    div_part = soup.find_all("div", class_="part")

    # 查找回调参数div_part
    data_tr = None
    for each in div_part:
        if re.match(".+通知参数", each.h3.text):
            data_tr = each.find("div", class_="table-wrp").table.tbody
            break
    # cnt = 0

    # for each in div_part:
    #     if re.match("通知参数", each.h3.text):
    #         cnt += 1
    #         if cnt == 1:
    #             continue
    #         data_tr = each.find("div", class_="table-wrp").table.tbody
    #         break

    if data_tr is None:
        return ""
    result = create_class(class_name, data_tr)
    return result


def create_class(class_name, tr):

    class_data = f"public class {class_name}\n{{\n"
    param_data = ""
    sub_class_data = ""
    constructor_param = ""
    constructor_comment = """
        /// <summary>
        /// 含参构造函数
        /// </summary>"""
    constructor_body = ""

    sub_class_name = ""
    for each in tr.children:
        if each == "\n":
            continue

        # 排除comment
        if isinstance(each, Comment):
            continue

        td = each.find_all("td")

        param_chiese_name = td[0].text
        param_name = td[1].text.replace(" ", "")
        param_type = td[2].text
        can_be_null = td[3].text

        if len(td) == 5:
            param_detail = (
                "<para>"
                + td[4]
                .text.replace("\t", "")
                .replace("\r\n", "")
                .replace("\n", "</para>\n        /// <para>")
                + "</para>"
            )
        else:
            param_detail = (
                "<para>"
                + td[3]
                .text.replace("\t", "")
                .replace("\r\n", "")
                .replace("\n", "</para>\n        /// <para>")
                + "</para>"
            )
            param_detail += "TODO: 多选一"

        # 去掉多余的空格
        continuous_bankets = re.findall(r" {2,}", param_detail)
        for each in continuous_bankets:
            param_detail = param_detail.replace(each, " ")

        if re.match(r".*否.*", can_be_null):
            param_detail += "\n        /// <para>可为null</para>"

        if sub_class_name != "":
            sub_class_data += create_class(sub_class_name, each.find("tbody"))
            sub_class_name = ""
            continue

        # 判断是否为子类型数据
        if re.match(r"\+.*", param_chiese_name):

            sub_class_name = format_class_name(param_name)
            param_type = sub_class_name

            # 除去+
            param_chiese_name = param_chiese_name.replace("+", "")
            param_chiese_name = param_chiese_name.replace(" ", "")

        # 加入注释
        param_data += f"""
        /// <summary>
        /// {param_chiese_name}
        /// {param_detail}
        /// </summary>
        """

        # 处理类型
        if re.match("string.*", param_type):
            param_type = "string"

        if re.match("uint64.*", param_type):
            param_type = "ulong"

        if re.match("int64.*", param_type):
            param_type = "long"

        if re.match("uint32.*", param_type):
            param_type = "uint"

        if re.match("int32.*", param_type):
            param_type = "int"

        if re.match("boolean.*", param_type):
            param_type = "bool"

        # 判断是否是array
        if re.match(".*array.*", td[2].text.replace(" ", "")):
            # 没有子类 直接为string[]
            if sub_class_name == "":
                param_type = "string[]"
            # 有子类 为object[]
            else:
                param_type += "[]"

        # 加入函数声明
        param_data += f"public {param_type} {param_name} {{ get; set; }}\n"

        # 加入构造函数注释
        constructor_param_comment = (
            param_detail.replace("///", "").replace("\n", "").replace(" ", "")
        )
        constructor_comment += f'\n/// <param name="{param_name}">{param_chiese_name} {constructor_param_comment}</param>'

        # 加入构造函数参数
        if constructor_param != "":
            constructor_param += ", "
        constructor_param += f"{param_type} {param_name}"

        # 加入构造函数主体
        constructor_body += f"this.{param_name} = {param_name};\n"

    # 连接构造函数

    class_data += f"{constructor_comment}\n        public {class_name}({constructor_param})\n        {{\n        {constructor_body}        }}\n"

    # 连接无参构造函数

    class_data += f"""
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public {class_name}()
        {{
        }}
        """
    # 连接参数声明
    class_data += param_data

    # 加上子类型数据
    if sub_class_data != "":
        class_data += "\n#region 子数据类型\n"
        class_data += sub_class_data
        class_data += "\n#endregion"

    class_data += "\n}\n\n"

    return class_data


# 将字符串写出到文件
def write_result(path, result):
    file_to_write = open(path, "w", encoding="utf-8")
    file_to_write.write(result)
    file_to_write.close()


# 获得首字母以及下划线后字母都大写的类名
def format_class_name(class_name):
    # 首字母大写
    class_name = re.sub(r"^.", class_name[0].upper(), class_name)

    underscore_words = re.findall("_.", class_name)

    for each in underscore_words:
        class_name = class_name.replace(each, each.upper())

    return class_name


def get_entity(url, api_name):
    # 获取页面
    res = request_page(url)

    # 获取请求数据
    request_data_name = f"{api_name}RequestData"
    api_request_data = get_api_request_data(res, request_data_name)
    write_result(f"{request_data_name}.cs", api_request_data)

    # 获取返回数据
    return_json_name = f"{api_name}ReturnJson"
    api_return_json = get_api_return_json(res, return_json_name)
    write_result(f"{return_json_name}.cs", api_return_json)

    # 获取回调数据
    notify_json_name = f"{api_name}NotifyJson"
    api_notify_json = get_api_notify_json(res, notify_json_name)
    write_result(f"{notify_json_name}.cs", api_notify_json)


def main():
    # 输入api信息 交付模式
    # print("请输入文档链接:")
    # url = input()
    # print("请输入api名:")
    # api_name = input()
    name_base = "chapter10_2_"
    name = name_base

    begin = 16
    end = 18
    for i in range(begin, end + 1):
        name = name_base + str(i)
        get_entity(f"https://pay.weixin.qq.com/wiki/doc/apiv3/apis/{name}.shtml", name)


if __name__ == "__main__":
    main()