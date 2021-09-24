public class chapter6_1_6RequestData
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="openid">用户标识 <para>path微信用户在商户对应appid下的唯一标识</para><para>示例值：oUpF8uMuAJO_M2pxb1Q9zNjWeS6o</para><para></para></param>
/// <param name="service_id">服务ID <para>body该服务ID有本接口对应产品的权限.</para><para>示例值：2002000000000558128851361561536</para></param>
/// <param name="appid">应用ID <para>body微信公众平台分配的与传入的商户号建立了支付绑定关系的appid，可在公众平台查看绑定关系.需要在本系统先进行配置.</para><para>示例值：wxd678efh567hg6787</para></param>
/// <param name="reason">撤销原因 <para>body撤销原因</para><para>示例值：reason</para></param>
        public chapter6_1_6RequestData(string openid, string service_id, string appid, string reason)
        {
        this.openid = openid;
this.service_id = service_id;
this.appid = appid;
this.reason = reason;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public chapter6_1_6RequestData()
        {
        }
        
        /// <summary>
        /// 用户标识
        /// <para>path微信用户在商户对应appid下的唯一标识 </para>
 /// <para>示例值：oUpF8uMuAJO_M2pxb1Q9zNjWeS6o</para>
 /// <para></para>
        /// </summary>
        public string openid { get; set; }

        /// <summary>
        /// 服务ID
        /// <para>body该服务ID有本接口对应产品的权限. </para>
 /// <para>示例值：2002000000000558128851361561536</para>
        /// </summary>
        public string service_id { get; set; }

        /// <summary>
        /// 应用ID
        /// <para>body微信公众平台分配的与传入的商户号建立了支付绑定关系的appid，可在公众平台查看绑定关系.需要在本系统先进行配置. </para>
 /// <para>示例值：wxd678efh567hg6787</para>
        /// </summary>
        public string appid { get; set; }

        /// <summary>
        /// 撤销原因
        /// <para>body撤销原因</para>
 /// <para>示例值：reason</para>
        /// </summary>
        public string reason { get; set; }

}

