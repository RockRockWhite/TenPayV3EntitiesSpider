public class chapter8_6_4RequestData
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="appid">小程序appid <para>query顾客授权积分时使用的小程序的appid</para><para>示例值：wx1234567890abcdef</para></param>
/// <param name="openid">顾客openid <para>path顾客授权时使用的小程序上的openid</para><para>示例值：oWmnN4xxxxxxxxxxe92NHIGf1xd8</para></param>
        public chapter8_6_4RequestData(string appid, string openid)
        {
        this.appid = appid;
this.openid = openid;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public chapter8_6_4RequestData()
        {
        }
        
        /// <summary>
        /// 小程序appid
        /// <para>query顾客授权积分时使用的小程序的appid </para>
 /// <para>示例值：wx1234567890abcdef</para>
        /// </summary>
        public string appid { get; set; }

        /// <summary>
        /// 顾客openid
        /// <para>path顾客授权时使用的小程序上的openid </para>
 /// <para>示例值：oWmnN4xxxxxxxxxxe92NHIGf1xd8</para>
        /// </summary>
        public string openid { get; set; }

}

