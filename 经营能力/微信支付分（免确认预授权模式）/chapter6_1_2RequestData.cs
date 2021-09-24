public class chapter6_1_2RequestData
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="service_id">服务id <para>body该服务ID有本接口对应产品的权限.</para><para>示例值：500001</para></param>
/// <param name="appid">应用ID <para>body服务商申请的公众号或移动应用APPID</para><para>示例值：wxd678efh567hg6787</para></param>
/// <param name="authorization_code">授权协议号 <para>body商户系统内部授权协议号，要求此参数只能由数字、大小写字母_-*组成，且在同一个商户号下唯一。</para><para>示例值：1234323JKHDFE1243252</para></param>
/// <param name="notify_url">通知地址 <para>body商户接收授权回调通知的地址 </para><para>示例值：http://www.qq.com</para><para>可为null</para></param>
        public chapter6_1_2RequestData(string service_id, string appid, string authorization_code, string notify_url)
        {
        this.service_id = service_id;
this.appid = appid;
this.authorization_code = authorization_code;
this.notify_url = notify_url;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public chapter6_1_2RequestData()
        {
        }
        
        /// <summary>
        /// 服务id
        /// <para>body该服务ID有本接口对应产品的权限. </para>
 /// <para>示例值：500001</para>
        /// </summary>
        public string service_id { get; set; }

        /// <summary>
        /// 应用ID
        /// <para>body服务商申请的公众号或移动应用APPID </para>
 /// <para>示例值：wxd678efh567hg6787</para>
        /// </summary>
        public string appid { get; set; }

        /// <summary>
        /// 授权协议号
        /// <para>body商户系统内部授权协议号，要求此参数只能由数字、大小写字母_-*组成，且在同一个商户号下唯一。</para>
 /// <para>示例值：1234323JKHDFE1243252</para>
        /// </summary>
        public string authorization_code { get; set; }

        /// <summary>
        /// 通知地址
        /// <para>body商户接收授权回调通知的地址 </para>
 /// <para>示例值：http://www.qq.com</para>
        /// <para>可为null</para>
        /// </summary>
        public string notify_url { get; set; }

}

