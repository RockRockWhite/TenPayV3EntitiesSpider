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


def get_api_request_data(res):

    # 处理请求
    soup = bs4.BeautifulSoup(res.text, "html.parser")

    div_part = soup.find_all("div", class_="part")

    # 查找请求参数div_part
    request_data_tr = None
    for each in div_part:
        if each.h3.text == "请求参数":
            request_data_tr = each.find("div", class_="table-wrp").table.tbody
            break

    result = create_class("test", request_data_tr)
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

        td = each.find_all("td")

        param_chiese_name = td[0].text
        param_name = td[1].text
        param_type = td[2].text
        can_be_null = td[3].text
        param_detail = (
            "<para>"
            + td[4]
            .text.replace("\t", "")
            .replace("\r\n", "")
            .replace("\n", "</para>\n        /// <para>")
            + "</para>"
        )
        if re.match(r".*是.*", can_be_null):
            param_detail += "\n        /// <para>可为null</para>"

        if sub_class_name != "":
            sub_class_data += create_class(sub_class_name, each)
            sub_class_name = ""
            continue

        # 判断是否为子类型数据
        if re.match(r"\+.*", param_chiese_name):
            sub_class_name = param_name.upper()
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

        if re.match("string.*", param_type):
            param_type = "string"

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

    class_data += "\n}\n"

    return class_data


def get_trans_and_example(word):

    url = f"https://dict.youdao.com/search?q={word}&keyfrom=new-fanyi.smartResult"
    headers = {
        "User-Agent": r"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) "
        r"Chrome/88.0.4324.150 Safari/537.36"
    }

    # 发送请求
    res = request.get(url=url, headers=headers)

    # 处理请求
    soup = bs4.BeautifulSoup(res.text, "html.parser")

    word_trans = soup.find("div", class_="trans-container").text
    word_trans = word_trans.split("\n\n[")[0]

    word_trans = word_trans.split("\n\n")[1]

    examples = soup.find_all("div", class_="examples")

    best_example = ""

    for each in examples:

        if best_example == "":
            best_example = each.text

        else:
            best_example = (
                each.text if len(best_example) > len(each.text) else best_example
            )

    return word + "\n\n" + word_trans + "\n" + best_example


def get_words_list(path):

    file = open(path, "rt", encoding="utf-8")
    file_context = file.read()
    file.close()

    return file_context


def write_result(path, result):

    file_to_write = open(path, "w", encoding="utf-8")
    file_to_write.write(result)
    file_to_write.close()


def main():
    res = request_page(
        "https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_1.shtml"
    )

    result = get_api_request_data(res)
    write_result("result.cs", result)
    # # 读入文件
    # print("reading words.txt...")
    # words_text = get_words_list("words.txt")
    # words_list = words_text.split("\n")

    # result = ""

    # for each in words_list:
    #     print(f"getting {each}...")
    #     curr_result = get_trans_and_example(each)
    #     result += "\n\n"
    #     result += curr_result

    # write_result("result.txt", result)

    # print("Succeed in writing to  result.txt...")


if __name__ == "__main__":
    main()