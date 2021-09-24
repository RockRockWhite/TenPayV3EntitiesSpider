public class chapter6_1_5RequestData
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="service_id">服务ID <para>query该服务ID有本接口对应产品的权限. </para><para>示例值：2002000000000558128851361561536</para><para></para></param>
/// <param name="appid">应用ID <para>query微信公众平台分配的与传入的商户号建立了支付绑定关系的appid，可在公众平台查看绑定关系，此参数需在本系统先进行配置。 </para><para>示例值：wxd678efh567hg6787</para><para></para></param>
/// <param name="openid">用户标识 <para>path微信用户在商户对应appid下的唯一标识 </para><para>示例值：oUpF8uMuAJO_M2pxb1Q9zNjWeS6o</para><para></para></param>
        public chapter6_1_5RequestData(string service_id, string appid, string openid)
        {
        this.service_id = service_id;
this.appid = appid;
this.openid = openid;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public chapter6_1_5RequestData()
        {
        }
        
        /// <summary>
        /// 服务ID
        /// <para>query该服务ID有本接口对应产品的权限. </para>
 /// <para>示例值：2002000000000558128851361561536</para>
 /// <para></para>
        /// </summary>
        public string service_id { get; set; }

        /// <summary>
        /// 应用ID
        /// <para>query微信公众平台分配的与传入的商户号建立了支付绑定关系的appid，可在公众平台查看绑定关系，此参数需在本系统先进行配置。 </para>
 /// <para>示例值：wxd678efh567hg6787</para>
 /// <para></para>
        /// </summary>
        public string appid { get; set; }

        /// <summary>
        /// 用户标识
        /// <para>path微信用户在商户对应appid下的唯一标识 </para>
 /// <para>示例值：oUpF8uMuAJO_M2pxb1Q9zNjWeS6o</para>
 /// <para></para>
        /// </summary>
        public string openid { get; set; }

}

