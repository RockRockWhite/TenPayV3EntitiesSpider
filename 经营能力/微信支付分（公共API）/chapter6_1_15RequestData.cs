public class chapter6_1_15RequestData
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="out_order_no">商户服务订单号  <para>query商户系统内部服务订单号（不是交易单号），与创建订单时一致</para><para>示例值：1234323JKHDFE1243252</para></param>
/// <param name="query_id">回跳查询ID  <para>query微信侧回跳到商户前端时用于查单的单据查询id。详见章节“小程序跳转接口，回跳商户接口”。商户单号与回跳查询id必填其中一个.不允许都填写或都不填写。</para><para>示例值：15646546545165651651</para>TODO:多选一</param>
/// <param name="service_id">服务ID  <para>query该服务ID有本接口对应产品的权限</para><para>示例值：500001</para></param>
/// <param name="appid">应用ID  <para>query微信公众平台分配的与传入的商户号建立了支付绑定关系的appid，可在公众平台查看绑定关系，此参数需在本系统先进行配置。</para><para>示例值：wxd678efh567hg6787</para></param>
        public chapter6_1_15RequestData(string out_order_no, string query_id, string service_id, string appid)
        {
        this.out_order_no = out_order_no;
this.query_id = query_id;
this.service_id = service_id;
this.appid = appid;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public chapter6_1_15RequestData()
        {
        }
        
        /// <summary>
        /// 商户服务订单号 
        /// <para>query 商户系统内部服务订单号（不是交易单号），与创建订单时一致 </para>
 /// <para>示例值：1234323JKHDFE1243252</para>
        /// </summary>
        public string out_order_no { get; set; }

        /// <summary>
        /// 回跳查询ID 
        /// <para>query 微信侧回跳到商户前端时用于查单的单据查询id。详见章节“小程序跳转接口，回跳商户接口”。 商户单号与回跳查询id必填其中一个.不允许都填写或都不填写。 </para>
 /// <para>示例值：15646546545165651651</para>TODO: 多选一
        /// </summary>
        public string query_id { get; set; }

        /// <summary>
        /// 服务ID 
        /// <para>query 该服务ID有本接口对应产品的权限 </para>
 /// <para>示例值：500001</para>
        /// </summary>
        public string service_id { get; set; }

        /// <summary>
        /// 应用ID 
        /// <para>query 微信公众平台分配的与传入的商户号建立了支付绑定关系的appid，可在公众平台查看绑定关系，此参数需在本系统先进行配置。 </para>
 /// <para>示例值：wxd678efh567hg6787</para>
        /// </summary>
        public string appid { get; set; }

}

