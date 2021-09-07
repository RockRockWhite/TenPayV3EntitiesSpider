public class TestApiRequestData
{

    /// <summary>
    /// 含参构造函数
    /// </summary>
    /// <param name="appid">应用ID  <para>body由微信生成的应用ID，全局唯一。请求基础下单接口时请注意APPID的应用属性，例如公众号场景下，需使用应用属性为公众号的APPID</para><para>示例值：wxd678efh567hg6787</para><para>可为null</para></param>
    /// <param name="mchid">直连商户号  <para>body直连商户的商户号，由微信支付生成并下发。</para><para>示例值：1230000109</para><para>可为null</para></param>
    /// <param name="description">商品描述  <para>body商品描述</para><para>示例值：Image形象店-深圳腾大-QQ公仔</para><para>可为null</para></param>
    /// <param name="out_trade_no">商户订单号  <para>body商户系统内部订单号，只能是数字、大小写字母_-*且在同一个商户号下唯一</para><para>示例值：1217752501201407033233368018</para><para>可为null</para></param>
    /// <param name="time_expire">交易结束时间  <para>body订单失效时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss表示时分秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35+08:00表示，北京时间2015年5月20日 13点29分35秒。订单失效时间是针对订单号而言的，由于在请求支付的时候有一个必传参数prepay_id只有两小时的有效期，所以在重入时间超过2小时的时候需要重新请求下单接口获取新的prepay_id。其他详见时间规则time_expire只能第一次下单传值，不允许二次修改，二次修改系统将报错。如用户支付失败后，需再次支付，需更换原订单号重新下单。</para><para>建议：最短失效时间间隔大于1分钟</para><para>示例值：2018-06-08T10:34:56+08:00</para></param>
    /// <param name="attach">附加数据  <para>body附加数据，在查询API和支付通知中原样返回，可作为自定义参数使用</para><para>示例值：自定义数据 </para></param>
    /// <param name="notify_url">通知地址  <para>body异步接收微信支付结果通知的回调地址，通知url必须为外网可访问的url，不能携带参数。公网域名必须为https，如果是走专线接入，使用专线NATIP或者私有回调域名可使用http</para><para>可为null</para></param>
    /// <param name="goods_tag">订单优惠标记  <para>body订单优惠标记</para><para>示例值：WXG</para></param>
    /// <param name="amount">订单金额 <para>body订单金额信息</para><para>可为null</para></param>
    /// <param name="payer">支付者 <para>body支付者信息</para><para>可为null</para></param>
    /// <param name="detail">优惠功能 <para>body优惠功能</para></param>
    /// <param name="scene_info">场景信息 <para>body支付场景描述</para></param>
    /// <param name="settle_info">结算信息 <para>body结算信息</para></param>
    public TestApiRequestData(string appid, string mchid, string description, string out_trade_no, string time_expire, string attach, string notify_url, string goods_tag, Amount amount, Payer payer, Detail detail, Scene_Info scene_info, Settle_Info settle_info)
    {
        this.appid = appid;
        this.mchid = mchid;
        this.description = description;
        this.out_trade_no = out_trade_no;
        this.time_expire = time_expire;
        this.attach = attach;
        this.notify_url = notify_url;
        this.goods_tag = goods_tag;
        this.amount = amount;
        this.payer = payer;
        this.detail = detail;
        this.scene_info = scene_info;
        this.settle_info = settle_info;
    }

    /// <summary>
    /// 无参构造函数
    /// </summary>
    public TestApiRequestData()
    {
    }

    /// <summary>
    /// 应用ID 
    /// <para>body 由微信生成的应用ID，全局唯一。请求基础下单接口时请注意APPID的应用属性，例如公众号场景下，需使用应用属性为公众号的APPID </para>
    /// <para>示例值：wxd678efh567hg6787 </para>
    /// <para>可为null</para>
    /// </summary>
    public string appid { get; set; }

    /// <summary>
    /// 直连商户号 
    /// <para>body 直连商户的商户号，由微信支付生成并下发。 </para>
    /// <para>示例值：1230000109 </para>
    /// <para>可为null</para>
    /// </summary>
    public string mchid { get; set; }

    /// <summary>
    /// 商品描述 
    /// <para>body 商品描述 </para>
    /// <para>示例值：Image形象店-深圳腾大-QQ公仔 </para>
    /// <para>可为null</para>
    /// </summary>
    public string description { get; set; }

    /// <summary>
    /// 商户订单号 
    /// <para>body 商户系统内部订单号，只能是数字、大小写字母_-*且在同一个商户号下唯一 </para>
    /// <para>示例值：1217752501201407033233368018 </para>
    /// <para>可为null</para>
    /// </summary>
    public string out_trade_no { get; set; }

    /// <summary>
    /// 交易结束时间 
    /// <para>body 订单失效时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss表示时分秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35+08:00表示，北京时间2015年5月20日 13点29分35秒。订单失效时间是针对订单号而言的，由于在请求支付的时候有一个必传参数prepay_id只有两小时的有效期，所以在重入时间超过2小时的时候需要重新请求下单接口获取新的prepay_id。其他详见时间规则time_expire只能第一次下单传值，不允许二次修改，二次修改系统将报错。如用户支付失败后，需再次支付，需更换原订单号重新下单。 </para>
    /// <para>建议：最短失效时间间隔大于1分钟</para>
    /// <para>示例值：2018-06-08T10:34:56+08:00 </para>
    /// </summary>
    public string time_expire { get; set; }

    /// <summary>
    /// 附加数据 
    /// <para>body 附加数据，在查询API和支付通知中原样返回，可作为自定义参数使用 </para>
    /// <para>示例值：自定义数据   </para>
    /// </summary>
    public string attach { get; set; }

    /// <summary>
    /// 通知地址 
    /// <para>body异步接收微信支付结果通知的回调地址，通知url必须为外网可访问的url，不能携带参数。公网域名必须为https，如果是走专线接入，使用专线NAT IP或者私有回调域名可使用http</para>
    /// <para>可为null</para>
    /// </summary>
    public string notify_url { get; set; }

    /// <summary>
    /// 订单优惠标记 
    /// <para>body 订单优惠标记 </para>
    /// <para>示例值：WXG </para>
    /// </summary>
    public string goods_tag { get; set; }

    /// <summary>
    /// 订单金额
    /// <para>body 订单金额信息</para>
    /// <para>可为null</para>
    /// </summary>
    public Amount amount { get; set; }

    /// <summary>
    /// 支付者
    /// <para>body 支付者信息</para>
    /// <para>可为null</para>
    /// </summary>
    public Payer payer { get; set; }

    /// <summary>
    /// 优惠功能
    /// <para>body 优惠功能</para>
    /// </summary>
    public Detail detail { get; set; }

    /// <summary>
    /// 场景信息
    /// <para>body 支付场景描述</para>
    /// </summary>
    public Scene_Info scene_info { get; set; }

    /// <summary>
    /// 结算信息
    /// <para>body 结算信息</para>
    /// </summary>
    public Settle_Info settle_info { get; set; }

    #region 子数据类型
    public class Amount
    {

        /// <summary>
        /// 含参构造函数
        /// </summary>
        /// <param name="total">总金额  <para>订单总金额，单位为分。</para><para>示例值：100</para><para>可为null</para></param>
        /// <param name="currency">货币类型  <para>CNY：人民币，境内商户号仅支持人民币。</para><para>示例值：CNY</para></param>
        public Amount(int total, string currency)
        {
            this.total = total;
            this.currency = currency;
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

        /// <summary>
        /// 货币类型 
        /// <para>CNY：人民币，境内商户号仅支持人民币。 </para>
        /// <para>示例值：CNY </para>
        /// </summary>
        public string currency { get; set; }

    }

    public class Payer
    {

        /// <summary>
        /// 含参构造函数
        /// </summary>
        /// <param name="openid">用户标识  <para>用户在直连商户appid下的唯一标识。下单前需获取到用户的Openid，Openid获取详见</para><para>示例值：oUpF8uMuAJO_M2pxb1Q9zNjWeS6o</para><para>可为null</para></param>
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
        /// <para>用户在直连商户appid下的唯一标识。 下单前需获取到用户的Openid，Openid获取详见</para>
        /// <para>示例值：oUpF8uMuAJO_M2pxb1Q9zNjWeS6o </para>
        /// <para>可为null</para>
        /// </summary>
        public string openid { get; set; }

    }

    public class Detail
    {

        /// <summary>
        /// 含参构造函数
        /// </summary>
        /// <param name="cost_price">订单原价  <para>1、商户侧一张小票订单可能被分多次支付，订单原价用于记录整张小票的交易金额。2、当订单原价与支付金额不相等，则不享受优惠。3、该字段主要用于防止同一张小票分多次支付，以享受多次优惠的情况，正常支付订单不必上传此参数。</para><para>示例值：608800</para></param>
        /// <param name="invoice_id">商品小票ID  <para>商家小票ID</para><para>示例值：微信123</para></param>
        /// <param name="goods_detail">单品列表 <para>单品列表信息条目个数限制：【1，6000】</para></param>
        public Detail(int cost_price, string invoice_id, Goods_Detail goods_detail)
        {
            this.cost_price = cost_price;
            this.invoice_id = invoice_id;
            this.goods_detail = goods_detail;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Detail()
        {
        }

        /// <summary>
        /// 订单原价 
        /// <para>1、商户侧一张小票订单可能被分多次支付，订单原价用于记录整张小票的交易金额。 2、当订单原价与支付金额不相等，则不享受优惠。 3、该字段主要用于防止同一张小票分多次支付，以享受多次优惠的情况，正常支付订单不必上传此参数。 </para>
        /// <para>示例值：608800 </para>
        /// </summary>
        public int cost_price { get; set; }

        /// <summary>
        /// 商品小票ID 
        /// <para>商家小票ID </para>
        /// <para>示例值：微信123 </para>
        /// </summary>
        public string invoice_id { get; set; }

        /// <summary>
        /// 单品列表
        /// <para>单品列表信息 条目个数限制：【1，6000】 </para>
        /// </summary>
        public Goods_Detail goods_detail { get; set; }

        #region 子数据类型
        public class Goods_Detail
        {

            /// <summary>
            /// 含参构造函数
            /// </summary>
            /// <param name="merchant_goods_id">商户侧商品编码  <para>由半角的大小写字母、数字、中划线、下划线中的一种或几种组成。</para><para>示例值：1246464644</para><para>可为null</para></param>
            /// <param name="wechatpay_goods_id">微信侧商品编码  <para>微信支付定义的统一商品编号（没有可不传）</para><para>示例值：1001</para></param>
            /// <param name="goods_name">商品名称  <para>商品的实际名称</para><para>示例值：iPhoneX256G</para></param>
            /// <param name="quantity">商品数量  <para>用户购买的数量</para><para>示例值：1</para><para>可为null</para></param>
            /// <param name="unit_price">商品单价  <para>商品单价，单位为分</para><para>示例值：828800</para><para>可为null</para></param>
            public Goods_Detail(string merchant_goods_id, string wechatpay_goods_id, string goods_name, int quantity, int unit_price)
            {
                this.merchant_goods_id = merchant_goods_id;
                this.wechatpay_goods_id = wechatpay_goods_id;
                this.goods_name = goods_name;
                this.quantity = quantity;
                this.unit_price = unit_price;
            }

            /// <summary>
            /// 无参构造函数
            /// </summary>
            public Goods_Detail()
            {
            }

            /// <summary>
            /// 商户侧商品编码 
            /// <para>由半角的大小写字母、数字、中划线、下划线中的一种或几种组成。 </para>
            /// <para>示例值：1246464644 </para>
            /// <para>可为null</para>
            /// </summary>
            public string merchant_goods_id { get; set; }

            /// <summary>
            /// 微信侧商品编码 
            /// <para>微信支付定义的统一商品编号（没有可不传） </para>
            /// <para>示例值：1001 </para>
            /// </summary>
            public string wechatpay_goods_id { get; set; }

            /// <summary>
            /// 商品名称 
            /// <para>商品的实际名称 </para>
            /// <para>示例值：iPhoneX 256G </para>
            /// </summary>
            public string goods_name { get; set; }

            /// <summary>
            /// 商品数量 
            /// <para>用户购买的数量 </para>
            /// <para>示例值：1</para>
            /// <para>可为null</para>
            /// </summary>
            public int quantity { get; set; }

            /// <summary>
            /// 商品单价 
            /// <para>商品单价，单位为分 </para>
            /// <para>示例值：828800 </para>
            /// <para>可为null</para>
            /// </summary>
            public int unit_price { get; set; }

        }


        #endregion
    }

    public class Scene_Info
    {

        /// <summary>
        /// 含参构造函数
        /// </summary>
        /// <param name="payer_client_ip">用户终端IP  <para>用户的客户端IP，支持IPv4和IPv6两种格式的IP地址。</para><para>示例值：14.23.150.211</para><para>可为null</para></param>
        /// <param name="device_id">商户端设备号  <para>商户端设备号（门店号或收银设备ID）。</para><para>示例值：013467007045764</para></param>
        /// <param name="store_info">商户门店信息 <para>商户门店信息</para></param>
        public Scene_Info(string payer_client_ip, string device_id, Store_Info store_info)
        {
            this.payer_client_ip = payer_client_ip;
            this.device_id = device_id;
            this.store_info = store_info;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Scene_Info()
        {
        }

        /// <summary>
        /// 用户终端IP 
        /// <para>用户的客户端IP，支持IPv4和IPv6两种格式的IP地址。 </para>
        /// <para>示例值：14.23.150.211 </para>
        /// <para>可为null</para>
        /// </summary>
        public string payer_client_ip { get; set; }

        /// <summary>
        /// 商户端设备号 
        /// <para>商户端设备号（门店号或收银设备ID）。 </para>
        /// <para>示例值：013467007045764 </para>
        /// </summary>
        public string device_id { get; set; }

        /// <summary>
        /// 商户门店信息
        /// <para>商户门店信息 </para>
        /// </summary>
        public Store_Info store_info { get; set; }

        #region 子数据类型
        public class Store_Info
        {

            /// <summary>
            /// 含参构造函数
            /// </summary>
            /// <param name="id">门店编号  <para>商户侧门店编号</para><para>示例值：0001</para><para>可为null</para></param>
            /// <param name="name">门店名称  <para>商户侧门店名称</para><para>示例值：腾讯大厦分店</para></param>
            /// <param name="area_code">地区编码  <para>地区编码，详细请见省市区编号对照表。</para><para>示例值：440305</para></param>
            /// <param name="address">详细地址  <para>详细的商户门店地址</para><para>示例值：广东省深圳市南山区科技中一道10000号</para></param>
            public Store_Info(string id, string name, string area_code, string address)
            {
                this.id = id;
                this.name = name;
                this.area_code = area_code;
                this.address = address;
            }

            /// <summary>
            /// 无参构造函数
            /// </summary>
            public Store_Info()
            {
            }

            /// <summary>
            /// 门店编号 
            /// <para>商户侧门店编号 </para>
            /// <para>示例值：0001 </para>
            /// <para>可为null</para>
            /// </summary>
            public string id { get; set; }

            /// <summary>
            /// 门店名称 
            /// <para>商户侧门店名称 </para>
            /// <para>示例值：腾讯大厦分店 </para>
            /// </summary>
            public string name { get; set; }

            /// <summary>
            /// 地区编码 
            /// <para>地区编码，详细请见省市区编号对照表。 </para>
            /// <para>示例值：440305 </para>
            /// </summary>
            public string area_code { get; set; }

            /// <summary>
            /// 详细地址 
            /// <para>详细的商户门店地址 </para>
            /// <para>示例值：广东省深圳市南山区科技中一道10000号 </para>
            /// </summary>
            public string address { get; set; }

        }


        #endregion
    }

    public class Settle_Info
    {

        /// <summary>
        /// 含参构造函数
        /// </summary>
        /// <param name="profit_sharing">是否指定分账 <para>是否指定分账</para><para>示例值：false</para></param>
        public Settle_Info(boolean profit_sharing)
        {
            this.profit_sharing = profit_sharing;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Settle_Info()
        {
        }

        /// <summary>
        /// 是否指定分账
        /// <para>是否指定分账 </para>
        /// <para>示例值：false</para>
        /// </summary>
        public boolean profit_sharing { get; set; }

    }


    #endregion
}

