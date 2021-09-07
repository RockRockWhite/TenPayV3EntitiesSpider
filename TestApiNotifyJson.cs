public class TestApiNotifyJson
{

    /// <summary>
    /// 含参构造函数
    /// </summary>
    /// <param name="appid ">应用ID  <para>直连商户申请的公众号或移动应用appid。</para><para>示例值：wxd678efh567hg6787</para><para>可为null</para></param>
    /// <param name="mchid ">商户号  <para>商户的商户号，由微信支付生成并下发。</para><para>示例值：1230000109</para><para>可为null</para></param>
    /// <param name="out_trade_no ">商户订单号  <para>商户系统内部订单号，只能是数字、大小写字母_-*且在同一个商户号下唯一。特殊规则：最小字符长度为6</para><para>示例值：1217752501201407033233368018</para><para>可为null</para></param>
    /// <param name="transaction_id ">微信支付订单号  <para>微信支付系统生成的订单号。</para><para>示例值：1217752501201407033233368018</para><para>可为null</para></param>
    /// <param name="trade_type ">交易类型  <para>交易类型，枚举值：JSAPI：公众号支付NATIVE：扫码支付APP：APP支付MICROPAY：付款码支付MWEB：H5支付FACEPAY：刷脸支付</para><para>示例值：MICROPAY</para><para>可为null</para></param>
    /// <param name="trade_state ">交易状态  <para>交易状态，枚举值：SUCCESS：支付成功REFUND：转入退款NOTPAY：未支付CLOSED：已关闭REVOKED：已撤销（付款码支付）USERPAYING：用户支付中（付款码支付）PAYERROR：支付失败(其他原因，如银行返回失败)</para><para>示例值：SUCCESS</para><para>可为null</para></param>
    /// <param name="trade_state_desc ">交易状态描述  <para>交易状态描述</para><para>示例值：支付成功</para><para>可为null</para></param>
    /// <param name="bank_type ">付款银行  <para>银行类型，采用字符串类型的银行标识。银行标识请参考《银行类型对照表》</para><para>示例值：CMC</para><para>可为null</para></param>
    /// <param name="attach ">附加数据  <para>附加数据，在查询API和支付通知中原样返回，可作为自定义参数使用</para><para>示例值：自定义数据 </para></param>
    /// <param name="success_time ">支付完成时间  <para>支付完成时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss表示时分秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35+08:00表示，北京时间2015年5月20日 13点29分35秒。</para><para>示例值：2018-06-08T10:34:56+08:00</para><para>可为null</para></param>
    /// <param name="payer">支付者 <para>支付者信息</para><para>可为null</para></param>
    /// <param name="amount ">订单金额 <para>订单金额信息</para><para>可为null</para></param>
    /// <param name="scene_info ">场景信息 <para>支付场景信息描述</para></param>
    /// <param name="promotion_detail ">优惠功能 <para>优惠功能，享受优惠时返回该字段。</para></param>
    public TestApiNotifyJson(string appid, string mchid, string out_trade_no, string transaction_id, string trade_type, string trade_state, string trade_state_desc, string bank_type, string attach, string success_time, Payer payer, Amount amount, Scene_Info scene_info, Promotion_Detail promotion_detail)
    {
        this.appid = appid;
        this.mchid = mchid;
        this.out_trade_no = out_trade_no;
        this.transaction_id = transaction_id;
        this.trade_type = trade_type;
        this.trade_state = trade_state;
        this.trade_state_desc = trade_state_desc;
        this.bank_type = bank_type;
        this.attach = attach;
        this.success_time = success_time;
        this.payer = payer;
        this.amount = amount;
        this.scene_info = scene_info;
        this.promotion_detail = promotion_detail;
    }

    /// <summary>
    /// 无参构造函数
    /// </summary>
    public TestApiNotifyJson()
    {
    }

    /// <summary>
    /// 应用ID 
    /// <para>直连商户申请的公众号或移动应用appid。 </para>
    /// <para>示例值：wxd678efh567hg6787 </para>
    /// <para>可为null</para>
    /// </summary>
    public string appid { get; set; }

    /// <summary>
    /// 商户号 
    /// <para>商户的商户号，由微信支付生成并下发。 </para>
    /// <para>示例值：1230000109 </para>
    /// <para>可为null</para>
    /// </summary>
    public string mchid { get; set; }

    /// <summary>
    /// 商户订单号 
    /// <para>商户系统内部订单号，只能是数字、大小写字母_-*且在同一个商户号下唯一。 特殊规则：最小字符长度为6 </para>
    /// <para>示例值：1217752501201407033233368018 </para>
    /// <para>可为null</para>
    /// </summary>
    public string out_trade_no { get; set; }

    /// <summary>
    /// 微信支付订单号 
    /// <para>微信支付系统生成的订单号。 </para>
    /// <para>示例值：1217752501201407033233368018 </para>
    /// <para>可为null</para>
    /// </summary>
    public string transaction_id { get; set; }

    /// <summary>
    /// 交易类型 
    /// <para>交易类型，枚举值： JSAPI：公众号支付 NATIVE：扫码支付 APP：APP支付 MICROPAY：付款码支付 MWEB：H5支付 FACEPAY：刷脸支付 </para>
    /// <para>示例值：MICROPAY </para>
    /// <para>可为null</para>
    /// </summary>
    public string trade_type { get; set; }

    /// <summary>
    /// 交易状态 
    /// <para>交易状态，枚举值： SUCCESS：支付成功 REFUND：转入退款 NOTPAY：未支付 CLOSED：已关闭 REVOKED：已撤销（付款码支付） USERPAYING：用户支付中（付款码支付） PAYERROR：支付失败(其他原因，如银行返回失败) </para>
    /// <para>示例值：SUCCESS </para>
    /// <para>可为null</para>
    /// </summary>
    public string trade_state { get; set; }

    /// <summary>
    /// 交易状态描述 
    /// <para>交易状态描述 </para>
    /// <para>示例值：支付成功 </para>
    /// <para>可为null</para>
    /// </summary>
    public string trade_state_desc { get; set; }

    /// <summary>
    /// 付款银行 
    /// <para>银行类型，采用字符串类型的银行标识。银行标识请参考《银行类型对照表》 </para>
    /// <para>示例值：CMC </para>
    /// <para>可为null</para>
    /// </summary>
    public string bank_type { get; set; }

    /// <summary>
    /// 附加数据 
    /// <para>附加数据，在查询API和支付通知中原样返回，可作为自定义参数使用 </para>
    /// <para>示例值：自定义数据   </para>
    /// </summary>
    public string attach { get; set; }

    /// <summary>
    /// 支付完成时间 
    /// <para>支付完成时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss表示时分秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35+08:00表示，北京时间2015年5月20日 13点29分35秒。 </para>
    /// <para>示例值：2018-06-08T10:34:56+08:00 </para>
    /// <para>可为null</para>
    /// </summary>
    public string success_time { get; set; }

    /// <summary>
    /// 支付者
    /// <para>支付者信息</para>
    /// <para>可为null</para>
    /// </summary>
    public Payer payer { get; set; }

    /// <summary>
    /// 订单金额
    /// <para>订单金额信息 </para>
    /// <para>可为null</para>
    /// </summary>
    public Amount amount { get; set; }

    /// <summary>
    /// 场景信息
    /// <para>支付场景信息描述</para>
    /// </summary>
    public Scene_Info scene_info { get; set; }

    /// <summary>
    /// 优惠功能
    /// <para>优惠功能，享受优惠时返回该字段。 </para>
    /// </summary>
    public Promotion_Detail promotion_detail { get; set; }

    #region 子数据类型
    public class Payer
    {

        /// <summary>
        /// 含参构造函数
        /// </summary>
        /// <param name="openid ">用户标识  <para>用户在直连商户appid下的唯一标识。</para><para>示例值：oUpF8uMuAJO_M2pxb1Q9zNjWeS6o</para><para>可为null</para></param>
        public Payer(string openid)
        {
            this.openid = openid;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Payer()
        {
        }

        /// <summary>
        /// 用户标识 
        /// <para>用户在直连商户appid下的唯一标识。 </para>
        /// <para>示例值：oUpF8uMuAJO_M2pxb1Q9zNjWeS6o</para>
        /// <para>可为null</para>
        /// </summary>
        public string openid { get; set; }

    }
    public class Amount
    {

        /// <summary>
        /// 含参构造函数
        /// </summary>
        /// <param name="total ">总金额  <para>订单总金额，单位为分。</para><para>示例值：100</para><para>可为null</para></param>
        public Amount(int total)
        {
            this.total = total;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Amount()
        {
        }

        /// <summary>
        /// 总金额 
        /// <para>订单总金额，单位为分。 </para>
        /// <para>示例值：100 </para>
        /// <para>可为null</para>
        /// </summary>
        public int total { get; set; }

    }
    public class Scene_Info
    {

        /// <summary>
        /// 含参构造函数
        /// </summary>
        /// <param name="device_id ">商户端设备号  <para>终端设备号（门店号或收银设备ID）。</para><para>示例值：013467007045764</para></param>
        public Scene_Info(string device_id)
        {
            this.device_id = device_id;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Scene_Info()
        {
        }

        /// <summary>
        /// 商户端设备号 
        /// <para>终端设备号（门店号或收银设备ID）。</para>
        /// <para>示例值：013467007045764</para>
        /// </summary>
        public string device_id { get; set; }

    }
    public class Promotion_Detail
    {

        /// <summary>
        /// 含参构造函数
        /// </summary>
        /// <param name="coupon_id ">券ID  <para>券ID</para><para>示例值：109519</para><para>可为null</para></param>
        public Promotion_Detail(string coupon_id)
        {
            this.coupon_id = coupon_id;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Promotion_Detail()
        {
        }

        /// <summary>
        /// 券ID 
        /// <para>券ID </para>
        /// <para>示例值：109519 </para>
        /// <para>可为null</para>
        /// </summary>
        public string coupon_id { get; set; }

    }

    #endregion
}
