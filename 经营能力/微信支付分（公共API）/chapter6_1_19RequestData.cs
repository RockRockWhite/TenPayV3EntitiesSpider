public class chapter6_1_19RequestData
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="out_order_no">商户服务订单号  <para>path商户系统内部服务订单号（不是交易单号），与创建订单时一致。</para><para>示例值：2304203423948239423</para></param>
/// <param name="appid">应用ID  <para>body微信公众平台分配的与传入的商户号建立了支付绑定关系的appid，可在公众平台查看绑定关系，此参数需在本系统先进行配置。</para><para>示例值：wxd678efh567hg6787</para></param>
/// <param name="service_id">服务ID  <para>body该服务ID有本接口对应产品的权限。</para><para>示例值：500001</para></param>
        public chapter6_1_19RequestData(string out_order_no, string appid, string service_id)
        {
        this.out_order_no = out_order_no;
this.appid = appid;
this.service_id = service_id;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public chapter6_1_19RequestData()
        {
        }
        
        /// <summary>
        /// 商户服务订单号 
        /// <para>path商户系统内部服务订单号（不是交易单号），与创建订单时一致。 </para>
 /// <para>示例值：2304203423948239423 </para>
        /// </summary>
        public string out_order_no { get; set; }

        /// <summary>
        /// 应用ID 
        /// <para>body 微信公众平台分配的与传入的商户号建立了支付绑定关系的appid，可在公众平台查看绑定关系，此参数需在本系统先进行配置。 </para>
  /// <para>示例值：wxd678efh567hg6787 </para>
        /// </summary>
        public string appid { get; set; }

        /// <summary>
        /// 服务ID 
        /// <para>body 该服务ID有本接口对应产品的权限。</para>
 /// <para>示例值：500001 </para>
        /// </summary>
        public string service_id { get; set; }

}

