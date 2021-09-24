public class chapter6_1_3RequestData
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="service_id">服务ID <para>query该服务ID有本接口对应产品的权限。 </para><para>示例值：500001</para><para></para></param>
/// <param name="authorization_code">授权协议号 <para>path商户系统内部授权协议号，要求此参数只能由数字、大小写字母_-*组成，且在同一个商户号下唯一。</para><para>示例值：1234323JKHDFE1243252</para><para></para></param>
        public chapter6_1_3RequestData(string service_id, string authorization_code)
        {
        this.service_id = service_id;
this.authorization_code = authorization_code;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public chapter6_1_3RequestData()
        {
        }
        
        /// <summary>
        /// 服务ID
        /// <para>query 该服务ID有本接口对应产品的权限。 </para>
 /// <para>示例值：500001</para>
 /// <para></para>
        /// </summary>
        public string service_id { get; set; }

        /// <summary>
        /// 授权协议号
        /// <para>path商户系统内部授权协议号，要求此参数只能由数字、大小写字母_-*组成，且在同一个商户号下唯一。 </para>
 /// <para>示例值：1234323JKHDFE1243252</para>
 /// <para></para>
        /// </summary>
        public string authorization_code { get; set; }

}

