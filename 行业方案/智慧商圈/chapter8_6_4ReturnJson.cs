public class chapter8_6_4ReturnJson
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="openid">顾客openid <para>顾客授权时使用的小程序上的openid</para><para>示例值：oWmnN4xxxxxxxxxxe92NHIGf1xd8</para></param>
/// <param name="authorize_state">授权状态 <para>顾客授权商圈积分结果UNAUTHORIZED：未授权AUTHORIZED：已授权DEAUTHORIZED：已取消授权</para><para>示例值：UNAUTHORIZED</para></param>
/// <param name="authorize_time">授权时间 <para>顾客成功授权商圈积分的时间,遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss表示时分秒毫秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC8小时，即北京时间）。例如：2015-05-20T13:29:35+08:00表示北京时间2015年05月20日13点29分35秒（需要增加所有跟时间有关的参数的描述）</para><para>示例值：2020-05-20T13:29:35+08:00</para><para>可为null</para></param>
/// <param name="deauthorize_time">取消授权时间 <para>顾客关闭授权商圈积分的时间,遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss表示时分秒毫秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC8小时，即北京时间）。例如：2015-05-20T13:29:35+08:00表示北京时间2015年05月20日13点29分35秒（需要增加所有跟时间有关的参数的描述）</para><para>示例值：2020-05-20T13:29:35+08:00</para><para>可为null</para></param>
        public chapter8_6_4ReturnJson(string openid, string authorize_state, string authorize_time, string deauthorize_time)
        {
        this.openid = openid;
this.authorize_state = authorize_state;
this.authorize_time = authorize_time;
this.deauthorize_time = deauthorize_time;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public chapter8_6_4ReturnJson()
        {
        }
        
        /// <summary>
        /// 顾客openid
        /// <para>顾客授权时使用的小程序上的openid </para>
 /// <para>示例值：oWmnN4xxxxxxxxxxe92NHIGf1xd8</para>
        /// </summary>
        public string openid { get; set; }

        /// <summary>
        /// 授权状态
        /// <para>顾客授权商圈积分结果 UNAUTHORIZED：未授权  AUTHORIZED：已授权  DEAUTHORIZED：已取消授权 </para>
  /// <para>示例值：UNAUTHORIZED</para>
        /// </summary>
        public string authorize_state { get; set; }

        /// <summary>
        /// 授权时间
        /// <para>顾客成功授权商圈积分的时间,遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss表示时分秒毫秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35+08:00表示北京时间2015年05月20日13点29分35秒（需要增加所有跟时间有关的参数的描述） </para>
 /// <para>示例值：2020-05-20T13:29:35+08:00</para>
        /// <para>可为null</para>
        /// </summary>
        public string authorize_time { get; set; }

        /// <summary>
        /// 取消授权时间
        /// <para>顾客关闭授权商圈积分的时间,遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss表示时分秒毫秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35+08:00表示北京时间2015年05月20日13点29分35秒（需要增加所有跟时间有关的参数的描述） </para>
 /// <para>示例值：2020-05-20T13:29:35+08:00</para>
        /// <para>可为null</para>
        /// </summary>
        public string deauthorize_time { get; set; }

}

