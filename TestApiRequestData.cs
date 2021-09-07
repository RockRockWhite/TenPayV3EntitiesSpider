public class TestApiRequestData
{

    /// <summary>
    /// 含参构造函数
    /// </summary>
    /// <param name="combine_appid ">合单商户appid  <para>body合单发起方的appid。</para><para>示例值：wxd678efh567hg6787</para><para>可为null</para></param>
    /// <param name="combine_mchid ">合单商户号  <para>body合单发起方商户号。</para><para>示例值：1900000109</para><para>可为null</para></param>
    /// <param name="combine_out_trade_no ">合单商户订单号  <para>body合单支付总订单号，要求32个字符内，只能是数字、大小写字母_-|*@，且在同一个商户号下唯一。</para><para>示例值：P20150806125346</para><para>可为null</para></param>
    /// <param name="scene_info ">场景信息 <para>body支付场景信息描述</para></param>
    /// <param name="sub_orders ">子单信息 <para>body最多支持子单条数：10</para><para>可为null</para></param>
    /// <param name="combine_payer_info ">支付者 <para>body支付者信息</para></param>
    /// <param name="time_start ">交易起始时间  <para>body订单生成时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss表示时分秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC8小时，即北京时间）。例如：2015-05-20T13:29:35+08:00表示，北京时间2015年5月20日13点29分35秒。</para><para>示例值：2019-12-31T15:59:59+08:00</para></param>
    /// <param name="time_expire ">交易结束时间  <para>body订单失效时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss表示时分秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC8小时，即北京时间）。例如：2015-05-20T13:29:35+08:00表示，北京时间2015年5月20日13点29分35秒。</para><para>示例值：2019-12-31T15:59:59+08:00</para></param>
    /// <param name="notify_url ">通知地址  <para>body接收微信支付异步通知回调地址，通知url必须为直接可访问的URL，不能携带参数。格式: URL</para><para>示例值：https://yourapp.com/notify</para><para>可为null</para></param>
    public TestApiRequestData(string combine_appid, string combine_mchid, string combine_out_trade_no, Scene_Info scene_info, Sub_Orders sub_orders, Combine_Payer_Info combine_payer_info, string time_start, string time_expire, string notify_url)
    {
        this.combine_appid = combine_appid;
        this.combine_mchid = combine_mchid;
        this.combine_out_trade_no = combine_out_trade_no;
        this.scene_info = scene_info;
        this.sub_orders = sub_orders;
        this.combine_payer_info = combine_payer_info;
        this.time_start = time_start;
        this.time_expire = time_expire;
        this.notify_url = notify_url;
    }

    /// <summary>
    /// 无参构造函数
    /// </summary>
    public TestApiRequestData()
    {
    }

    /// <summary>
    /// 合单商户appid 
    /// <para>body 合单发起方的appid。</para>
    /// <para>示例值：wxd678efh567hg6787 </para>
    /// <para>可为null</para>
    /// </summary>
    public string combine_appid { get; set; }

    /// <summary>
    /// 合单商户号 
    /// <para>body合单发起方商户号。</para>
    /// <para>示例值：1900000109 </para>
    /// <para>可为null</para>
    /// </summary>
    public string combine_mchid { get; set; }

    /// <summary>
    /// 合单商户订单号 
    /// <para>body合单支付总订单号，要求32个字符内，只能是数字、大小写字母_-|*@ ，且在同一个商户号下唯一 。</para>
    /// <para>示例值：P20150806125346 </para>
    /// <para>可为null</para>
    /// </summary>
    public string combine_out_trade_no { get; set; }

    /// <summary>
    /// 场景信息
    /// <para>body支付场景信息描述</para>
    /// </summary>
    public Scene_Info scene_info { get; set; }

    /// <summary>
    /// 子单信息
    /// <para>body最多支持子单条数：10 </para>
    /// <para>可为null</para>
    /// </summary>
    public Sub_Orders sub_orders { get; set; }

    /// <summary>
    /// 支付者
    /// <para>body支付者信息</para>
    /// </summary>
    public Combine_Payer_Info combine_payer_info { get; set; }

    /// <summary>
    /// 交易起始时间 
    /// <para>body订单生成时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss表示时分秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35+08:00表示，北京时间2015年5月20日 13点29分35秒。</para>
    /// <para>示例值：2019-12-31T15:59:59+08:00 </para>
    /// </summary>
    public string time_start { get; set; }

    /// <summary>
    /// 交易结束时间 
    /// <para>body订单失效时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss表示时分秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35+08:00表示，北京时间2015年5月20日 13点29分35秒。</para>
    /// <para>示例值：2019-12-31T15:59:59+08:00 </para>
    /// </summary>
    public string time_expire { get; set; }

    /// <summary>
    /// 通知地址 
    /// <para>body接收微信支付异步通知回调地址，通知url必须为直接可访问的URL，不能携带参数。 格式: URL </para>
    /// <para>示例值：https://yourapp.com/notify </para>
    /// <para>可为null</para>
    /// </summary>
    public string notify_url { get; set; }

    #region 子数据类型
    public class Scene_Info
    {

        /// <summary>
        /// 含参构造函数
        /// </summary>
        /// <param name="device_id ">商户端设备号  <para>终端设备号（门店号或收银设备ID）。</para><para>示例值：POS1:123</para></param>
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
        /// <para>终端设备号（门店号或收银设备ID） 。 </para>
        /// <para>示例值：POS1:123 </para>
        /// </summary>
        public string device_id { get; set; }

    }

    public class Sub_Orders
    {

        /// <summary>
        /// 含参构造函数
        /// </summary>
        /// <param name="mchid ">子单商户号  <para>子单发起方商户号即合单参与方商户号，必须与发起方appid有绑定关系。</para><para>示例值：1900000109</para><para>可为null</para></param>
        public Sub_Orders(string mchid)
        {
            this.mchid = mchid;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Sub_Orders()
        {
        }

        /// <summary>
        /// 子单商户号 
        /// <para>子单发起方商户号即合单参与方商户号，必须与发起方appid有绑定关系。</para>
        /// <para>示例值：1900000109 </para>
        /// <para>可为null</para>
        /// </summary>
        public string mchid { get; set; }

    }

    public class Combine_Payer_Info
    {

        /// <summary>
        /// 含参构造函数
        /// </summary>
        /// <param name="openid ">用户标识  <para>使用合单appid获取的对应用户openid。是用户在商户appid下的唯一标识。</para><para>获取用户openid指引</para><para>示例值：oUpF8uMuAJO_M2pxb1Q9zNjWeS6o</para></param>
        public Combine_Payer_Info(string openid)
        {
            this.openid = openid;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Combine_Payer_Info()
        {
        }

        /// <summary>
        /// 用户标识 
        /// <para>使用合单appid获取的对应用户openid。是用户在商户appid下的唯一标识。 </para>
        /// <para>获取用户openid指引</para>
        /// <para>示例值：oUpF8uMuAJO_M2pxb1Q9zNjWeS6o </para>
        /// </summary>
        public string openid { get; set; }

    }


    #endregion
}

