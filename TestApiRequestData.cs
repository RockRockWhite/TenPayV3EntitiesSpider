public class TestApiRequestData
{

    /// <summary>
    /// 含参构造函数
    /// </summary>
    /// <param name="stock_name">批次名称  <para>body批次名称</para><para>校验规则：1、批次名称最多9个中文汉字2、批次名称最多20个字母3、批次名称中不能包含不当内容和特殊字符_,;|</para><para>示例值：微信支付代金券批次</para></param>
    /// <param name="comment">批次备注  <para>body仅制券商户可见，用于自定义信息。</para><para>校验规则：批次备注最多60个UTF8字符数</para><para>示例值：零售批次</para><para>可为null</para></param>
    /// <param name="belong_merchant">归属商户号  <para>body批次归属商户号</para><para>本字段暂未开放生效，但入参时请设置为当前创建代金券商户号即不会报错，暂时不支持入参其他的商户号</para><para>示例值：98568865</para></param>
    /// <param name="available_begin_time">可用时间-开始时间  <para>body批次开始时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss.sss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss.sss表示时分秒毫秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC8小时，即北京时间）。例如：2015-05-20T13:29:35.120+08:00表示，北京时间2015年5月20日13点29分35秒。</para><para>校验规则：1、开始时间不可早于当前时间2、不能创建365天后开始的批次3、批次可用时间范围最长为90天</para><para>示例值：2015-05-20T13:29:35.120+08:00</para></param>
    /// <param name="available_end_time">可用时间-结束时间  <para>body批次结束时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss.sss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss.sss表示时分秒毫秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC8小时，即北京时间）。例如：2015-05-20T13:29:35.120+08:00表示，北京时间2015年5月20日13点29分35秒。</para><para>校验规则：1、结束时间需晚于开始时间2、可用时间最长为90天3、有效时间间隔最短为1s</para><para>示例值：2015-05-20T13:29:35.120+08:00</para></param>
    /// <param name="stock_use_rule">发放规则 <para>body批次使用规则</para></param>
    /// <param name="pattern_info">样式设置 <para>body代金券详情页</para><para>可为null</para></param>
    /// <param name="coupon_use_rule">核销规则 <para>body核销规则</para></param>
    /// <param name="no_cash">营销经费  <para>body营销经费。枚举值：true：免充值false：预充值1、免充值：制券方无需提前充值资金，用户核销代金券时，直接从订单原价中扣除优惠减价金额，最终只将用户实际支付的金额结算给核销商户，商户实收少于订单原价。2、预充值：制券方需将优惠预算提前充值到微信支付商户可用余额中，用户核销代金券时，系统从制券方商户可用余额中扣除优惠减价部分对应的资金，连同用户实际支付的资金，一并结算给核销商户，不影响实收。</para><para>示例值：false</para></param>
    /// <param name="stock_type">批次类型  <para>body批次类型，仅支持：NORMAL：固定面额满减券批次</para><para></para><para>示例值：NORMAL</para></param>
    /// <param name="out_request_no">商户单据号  <para>body商户创建批次凭据号（格式：商户id+日期+流水号），可包含英文字母，数字，|，_，*，-等内容，不允许出现其他不合法符号，商户侧需保持商户单据号全局唯一。</para><para>示例值：89560002019101000121</para></param>
    /// <param name="ext_info">扩展属性  <para>body扩展属性字段，按json格式，如无需要则不填写。</para><para>该字段暂未开放</para><para>示例值：{'exinfo1':'1234','exinfo2':'3456'}</para><para>可为null</para></param>
    public TestApiRequestData(string stock_name, string comment, string belong_merchant, string available_begin_time, string available_end_time, Stock_Use_Rule stock_use_rule, Pattern_Info pattern_info, Coupon_Use_Rule coupon_use_rule, bool no_cash, string stock_type, string out_request_no, string ext_info)
    {
        this.stock_name = stock_name;
        this.comment = comment;
        this.belong_merchant = belong_merchant;
        this.available_begin_time = available_begin_time;
        this.available_end_time = available_end_time;
        this.stock_use_rule = stock_use_rule;
        this.pattern_info = pattern_info;
        this.coupon_use_rule = coupon_use_rule;
        this.no_cash = no_cash;
        this.stock_type = stock_type;
        this.out_request_no = out_request_no;
        this.ext_info = ext_info;
    }

    /// <summary>
    /// 无参构造函数
    /// </summary>
    public TestApiRequestData()
    {
    }

    /// <summary>
    /// 批次名称 
    /// <para>body 批次名称 </para>
    /// <para>校验规则：1、批次名称最多9个中文汉字2、批次名称最多20个字母3、批次名称中不能包含不当内容和特殊字符 _ , ; |</para>
    /// <para>示例值：微信支付代金券批次 </para>
    /// </summary>
    public string stock_name { get; set; }

    /// <summary>
    /// 批次备注 
    /// <para>body 仅制券商户可见，用于自定义信息。 </para>
    /// <para>校验规则：批次备注最多60个UTF8字符数</para>
    /// <para>示例值：零售批次 </para>
    /// <para>可为null</para>
    /// </summary>
    public string comment { get; set; }

    /// <summary>
    /// 归属商户号 
    /// <para>body 批次归属商户号 </para>
    /// <para>本字段暂未开放生效，但入参时请设置为当前创建代金券商户号即不会报错，暂时不支持入参其他的商户号</para>
    /// <para>示例值：98568865 </para>
    /// </summary>
    public string belong_merchant { get; set; }

    /// <summary>
    /// 可用时间-开始时间 
    /// <para>body 批次开始时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss.sss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss.sss表示时分秒毫秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35.120+08:00表示，北京时间2015年5月20日 13点29分35秒。 </para>
    /// <para>校验规则：1、开始时间不可早于当前时间2、不能创建365天后开始的批次3、批次可用时间范围最长为90天</para>
    /// <para>示例值：2015-05-20T13:29:35.120+08:00 </para>
    /// </summary>
    public string available_begin_time { get; set; }

    /// <summary>
    /// 可用时间-结束时间 
    /// <para>body 批次结束时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss.sss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss.sss表示时分秒毫秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35.120+08:00表示，北京时间2015年5月20日 13点29分35秒。 </para>
    /// <para>校验规则：1、结束时间需晚于开始时间2、可用时间最长为90天3、有效时间间隔最短为1s</para>
    /// <para>示例值：2015-05-20T13:29:35.120+08:00 </para>
    /// </summary>
    public string available_end_time { get; set; }

    /// <summary>
    /// 发放规则
    /// <para>body 批次使用规则 </para>
    /// </summary>
    public Stock_Use_Rule stock_use_rule { get; set; }

    /// <summary>
    /// 样式设置
    /// <para>body 代金券详情页</para>
    /// <para>可为null</para>
    /// </summary>
    public Pattern_Info pattern_info { get; set; }

    /// <summary>
    /// 核销规则
    /// <para>body 核销规则</para>
    /// </summary>
    public Coupon_Use_Rule coupon_use_rule { get; set; }

    /// <summary>
    /// 营销经费 
    /// <para>body 营销经费。枚举值： true：免充值 false：预充值 1、免充值：制券方无需提前充值资金，用户核销代金券时，直接从订单原价中扣除优惠减价金额，最终只将用户实际支付的金额结算给核销商户，商户实收少于订单原价。  2、预充值：制券方需将优惠预算提前充值到微信支付商户可用余额中，用户核销代金券时，系统从制券方商户可用余额中扣除优惠减价部分对应的资金，连同用户实际支付的资金，一并结算给核销商户，不影响实收。</para>
    /// <para>示例值：false </para>
    /// </summary>
    public bool no_cash { get; set; }

    /// <summary>
    /// 批次类型 
    /// <para>body 批次类型，仅支持： NORMAL：固定面额满减券批次</para>
    /// <para></para>
    /// <para>示例值：NORMAL</para>
    /// </summary>
    public string stock_type { get; set; }

    /// <summary>
    /// 商户单据号 
    /// <para>body 商户创建批次凭据号（格式：商户id+日期+流水号），可包含英文字母，数字，|，_，*，-等内容，不允许出现其他不合法符号，商户侧需保持商户单据号全局唯一。 </para>
    /// <para>示例值：89560002019101000121 </para>
    /// </summary>
    public string out_request_no { get; set; }

    /// <summary>
    /// 扩展属性 
    /// <para>body 扩展属性字段，按json格式，如无需要则不填写。 </para>
    /// <para> 该字段暂未开放</para>
    /// <para>示例值：{'exinfo1':'1234','exinfo2':'3456'} </para>
    /// <para>可为null</para>
    /// </summary>
    public string ext_info { get; set; }

    #region 子数据类型
    public class Stock_Use_Rule
    {

        /// <summary>
        /// 含参构造函数
        /// </summary>
        /// <param name="max_coupons">发放总上限  <para>最大发券数</para><para>校验规则：1、发放总个数最少5个2、发放总个数最多1000万个</para><para>示例值：100</para></param>
        /// <param name="max_amount">总预算  <para>最大发券预算，当营销经费no_cash选择预充值false时，激活批次时会从制券商户的余额中扣除预算，请保证账户金额充足，单位：分max_amount需要等于coupon_amount（面额）*max_coupons（发放总上限）</para><para></para><para>校验规则：批次总预算最多1亿元</para><para>示例值：5000</para></param>
        /// <param name="max_amount_by_day">单天预算发放上限  <para>设置此字段，允许指定单天最大发券预算，单位：分。</para><para>校验规则：1、不能大于总预算2、max_amount_by_day不可以为0</para><para>示例值：400</para><para>可为null</para></param>
        /// <param name="max_coupons_per_user">单个用户可领个数  <para>活动期间每个用户可领个数，当开启了自然人限领时，多个微信号同属于一个身份证时，视为同一用户。</para><para>校验规则：1、不能大于发放总个数2、最少为1个，最多为60个</para><para>示例值：3</para></param>
        /// <param name="natural_person_limit">是否开启自然人限制  <para>当开启了自然人限领时，多个微信号同属于一个身份证时，视为同一用户，枚举值true：是false：否</para><para>示例值：false</para></param>
        /// <param name="prevent_api_abuse">是否开启防刷拦截  <para>若开启防刷拦截，当用户命中恶意、小号、机器、羊毛党、黑产等风险行为时，无法成功发放代金券。枚举值true：是false：否</para><para>示例值：false</para></param>
        public Stock_Use_Rule(ulong max_coupons, ulong max_amount, ulong max_amount_by_day, uint max_coupons_per_user, bool natural_person_limit, bool prevent_api_abuse)
        {
            this.max_coupons = max_coupons;
            this.max_amount = max_amount;
            this.max_amount_by_day = max_amount_by_day;
            this.max_coupons_per_user = max_coupons_per_user;
            this.natural_person_limit = natural_person_limit;
            this.prevent_api_abuse = prevent_api_abuse;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Stock_Use_Rule()
        {
        }

        /// <summary>
        /// 发放总上限 
        /// <para>最大发券数 </para>
        /// <para>校验规则：1、发放总个数最少5个2、发放总个数最多1000万个</para>
        /// <para>示例值：100 </para>
        /// </summary>
        public ulong max_coupons { get; set; }

        /// <summary>
        /// 总预算 
        /// <para>最大发券预算，当营销经费no_cash选择预充值false时，激活批次时会从制券商户的余额中扣除预算，请保证账户金额充足，单位：分 max_amount需要等于coupon_amount（面额） * max_coupons（发放总上限）</para>
        /// <para></para>
        /// <para>校验规则：批次总预算最多1亿元</para>
        /// <para>示例值：5000 </para>
        /// </summary>
        public ulong max_amount { get; set; }

        /// <summary>
        /// 单天预算发放上限 
        /// <para>设置此字段，允许指定单天最大发券预算，单位：分。</para>
        /// <para>校验规则：    1、不能大于总预算    2、max_amount_by_day不可以为0</para>
        /// <para>示例值：400 </para>
        /// <para>可为null</para>
        /// </summary>
        public ulong max_amount_by_day { get; set; }

        /// <summary>
        /// 单个用户可领个数 
        /// <para>活动期间每个用户可领个数，当开启了自然人限领时，多个微信号同属于一个身份证时，视为同一用户。 </para>
        /// <para>校验规则：1、不能大于发放总个数2、最少为1个，最多为60个</para>
        /// <para>示例值：3 </para>
        /// </summary>
        public uint max_coupons_per_user { get; set; }

        /// <summary>
        /// 是否开启自然人限制 
        /// <para>当开启了自然人限领时，多个微信号同属于一个身份证时，视为同一用户，枚举值 true：是 false：否</para>
        /// <para>示例值：false </para>
        /// </summary>
        public bool natural_person_limit { get; set; }

        /// <summary>
        /// 是否开启防刷拦截 
        /// <para>若开启防刷拦截，当用户命中恶意、小号、机器、羊毛党、黑产等风险行为时，无法成功发放代金券。枚举值 true：是 false：否</para>
        /// <para>示例值：false </para>
        /// </summary>
        public bool prevent_api_abuse { get; set; }

    }

    public class Pattern_Info
    {

        /// <summary>
        /// 含参构造函数
        /// </summary>
        /// <param name="description">使用说明  <para>用于说明详细的活动规则，会展示在代金券详情页。</para><para>校验规则：最多1000个UTF8字符</para><para>示例值：微信支付营销代金券</para></param>
        /// <param name="merchant_logo">商户logo  <para>商户logo，仅支持通过《图片上传API》接口获取的图片URL地址。1、商户logo大小需为120像素*120像素。2、支持JPG/JPEG/PNG格式，且图片小于1M。3、最多128个UTF8字符</para><para>示例值：https://qpic.cn/xxx</para><para>可为null</para></param>
        /// <param name="merchant_name">品牌名称  <para>品牌名称，展示在用户卡包</para><para>校验规则：1、最多12个中文汉字2、最多36个英文字符</para><para>示例值：微信支付</para><para>可为null</para></param>
        /// <param name="background_color">背景颜色  <para>券的背景颜色，可设置10种颜色，色值请参考卡券背景颜色图。颜色取值为颜色图中的颜色名称。可选枚举字段不用则不传，不可以传空值</para><para>示例值：COLOR020</para><para>可为null</para></param>
        /// <param name="coupon_image">券详情图片  <para>券详情图片，850像素*350像素，且图片大小不超过2M，支持JPG/PNG格式，仅支持通过《图片上传API》接口获取的图片URL地址。</para><para>示例值：https://qpic.cn/xxx</para><para>可为null</para></param>
        public Pattern_Info(string description, string merchant_logo, string merchant_name, string background_color, string coupon_image)
        {
            this.description = description;
            this.merchant_logo = merchant_logo;
            this.merchant_name = merchant_name;
            this.background_color = background_color;
            this.coupon_image = coupon_image;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Pattern_Info()
        {
        }

        /// <summary>
        /// 使用说明 
        /// <para>用于说明详细的活动规则，会展示在代金券详情页。 </para>
        /// <para>校验规则：最多1000个UTF8字符</para>
        /// <para>示例值：微信支付营销代金券 </para>
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// 商户logo 
        /// <para>商户logo ，仅支持通过《图片上传API》接口获取的图片URL地址。 1、商户logo大小需为120像素*120像素。 2、支持JPG/JPEG/PNG格式，且图片小于1M。 3、最多128个UTF8字符</para>
        /// <para>示例值：https://qpic.cn/xxx </para>
        /// <para>可为null</para>
        /// </summary>
        public string merchant_logo { get; set; }

        /// <summary>
        /// 品牌名称 
        /// <para>品牌名称，展示在用户卡包 </para>
        /// <para>校验规则：1、最多12个中文汉字 2、最多36个英文字符</para>
        /// <para>示例值：微信支付 </para>
        /// <para>可为null</para>
        /// </summary>
        public string merchant_name { get; set; }

        /// <summary>
        /// 背景颜色 
        /// <para>券的背景颜色，可设置10种颜色，色值请参考卡券背景颜色图。颜色取值为颜色图中的颜色名称。可选枚举字段不用则不传，不可以传空值</para>
        /// <para>示例值：COLOR020 </para>
        /// <para>可为null</para>
        /// </summary>
        public string background_color { get; set; }

        /// <summary>
        /// 券详情图片 
        /// <para>券详情图片， 850像素*350像素，且图片大小不超过2M，支持JPG/PNG格式，仅支持通过《图片上传API》接口获取的图片URL地址。 </para>
        /// <para>示例值：https://qpic.cn/xxx </para>
        /// <para>可为null</para>
        /// </summary>
        public string coupon_image { get; set; }

    }

    public class Coupon_Use_Rule
    {

        /// <summary>
        /// 含参构造函数
        /// </summary>
        /// <param name="coupon_available_time">券生效时间 <para>允许指定券的特殊生效时间规则。</para><para>该字段暂未开放</para><para></para><para>可为null</para></param>
        /// <param name="fixed_normal_coupon">固定面额满减券使用规则 <para>stock_type为NORMAL时必填。</para><para>可为null</para></param>
        /// <param name="goods_tag">订单优惠标记  <para>订单优惠标记，按json格式。商户下单时需要传入相同的标记(goods_tag)，用户同时符合其他规则才能享受优惠</para><para>校验规则：1、最多允许录入50个2、每个订单优惠标记支持字母/数字/下划线，不超过128个UTF8字符。</para><para>示例值：["123321","456654"]</para><para>可为null</para></param>
        /// <param name="limit_pay	">指定付款方式 <para>指定付款方式的交易可核销/使用代金券，可指定零钱付款、指定银行卡付款，需填入支付方式编码，不在此列表中的银行卡，暂不支持此功能。黄色标记部分为不可使用的银行。</para><para>校验规则：条目个数限制为【1，1】。</para><para>零钱：CFT</para><para>示例值：ICBC_CREDIT</para><para>可为null</para></param>
        /// <param name="limit_card	">指定银行卡BIN <para>指定银行卡bin付款的交易可核销/使用代金券，当批次限定了指定银行卡时方可生效</para><para>可为null</para></param>
        /// <param name="trade_type">支付方式 <para>允许指定支付方式的交易才可核销/使用代金券，不填则默认“不限”。枚举值：MICROAPP：小程序支付APPPAY：APP支付PPAY：免密支付CARD：刷卡支付FACE：人脸支付OTHER：其他支付</para><para>示例值：["MICROAPP","APPPAY"]</para><para>可为null</para></param>
        /// <param name="combine_use">是否可叠加其他优惠  <para>允许指定本优惠是否可以和本商户号创建的其他券同时使用，不填则默认允许同时使用。枚举值：true：是false：否</para><para>示例值：false</para><para>可为null</para></param>
        /// <param name="available_items">可核销商品编码  <para>包含指定SKU商品编码的交易才可核销/使用代金券：活动商户在交易下单时，需传入用户购买的所有SKU商品编码，当命中代金券中设置的商品编码时可享受优惠。</para><para>校验规则：1、单个商品编码的字符长度为【1，128】2、条目个数限制为【1，50】</para><para>示例值：['123321','456654']</para><para>可为null</para></param>
        /// <param name="unavailable_items">不可核销商品编码  <para>该字段暂未开放包含指定SKU商品编码的交易不可核销/使用代金券。</para><para>校验规则：1、单个商品编码的字符长度为【1，128】2、条目个数限制为【1，50】</para><para>示例值：['789987','56765']</para><para>可为null</para></param>
        /// <param name="available_merchants">可用商户号  <para>可用商户的交易才可核销/使用代金券。当营销经费no_cash=false时，可用商户允许填入任何类型的特约商户或普通商户当营销经费no_cash=ture时，分为以下几种情况：1、创建商户是普通商户或服务商特约商户(子商户)：可添加本商户号或同品牌商户。</para><para>说明：若可用商户中，有特约商户(子商户)，那么特约商户自己发起的交易、以及服务商帮特约商户发起的交易，都可以使用代金券。2、创建商户是普通服务商：可添加已授权的子商户，详见《申请免充值代金券产品权限》。</para><para>说明：特约商户如果有多个服务商，那么服务商为他发起的交易，只要完成了免充值授权，都可以使用代金券；特约商户自己发起的交易不可以使用代金券。3、创建商户是渠道商、银行服务商或从业机构：可直接添加旗下任意子商户，不需要子商户授权。</para><para>校验规则：条目个数限制为【1，50】</para><para>示例值：['9856000','9856111']</para></param>
        public Coupon_Use_Rule(Coupon_Available_Time coupon_available_time, Fixed_Normal_Coupon fixed_normal_coupon, string[] goods_tag, string[] limit_pay, Limit_Card limit_card, string[] trade_type, bool combine_use, string[] available_items, string[] unavailable_items, string[] available_merchants)
        {
            this.coupon_available_time = coupon_available_time;
            this.fixed_normal_coupon = fixed_normal_coupon;
            this.goods_tag = goods_tag;
            this.limit_pay = limit_pay;
            this.limit_card = limit_card;
            this.trade_type = trade_type;
            this.combine_use = combine_use;
            this.available_items = available_items;
            this.unavailable_items = unavailable_items;
            this.available_merchants = available_merchants;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Coupon_Use_Rule()
        {
        }

        /// <summary>
        /// 券生效时间
        /// <para>允许指定券的特殊生效时间规则。</para>
        /// <para>该字段暂未开放</para>
        /// <para></para>
        /// <para>可为null</para>
        /// </summary>
        public Coupon_Available_Time coupon_available_time { get; set; }

        /// <summary>
        /// 固定面额满减券使用规则
        /// <para>stock_type为NORMAL时必填。</para>
        /// <para>可为null</para>
        /// </summary>
        public Fixed_Normal_Coupon fixed_normal_coupon { get; set; }

        /// <summary>
        /// 订单优惠标记 
        /// <para>订单优惠标记，按json格式。 商户下单时需要传入相同的标记(goods_tag)，用户同时符合其他规则才能享受优惠</para>
        /// <para>校验规则：1、最多允许录入50个2、每个订单优惠标记支持字母/数字/下划线，不超过128个UTF8字符。</para>
        /// <para>示例值：["123321","456654"]</para>
        /// <para>可为null</para>
        /// </summary>
        public string[] goods_tag { get; set; }

        /// <summary>
        /// 指定付款方式
        /// <para>指定付款方式的交易可核销/使用代金券，可指定零钱付款、指定银行卡付款，需填入支付方式编码，不在此列表中的银行卡，暂不支持此功能。黄色标记部分为不可使用的银行。</para>
        /// <para>校验规则：条目个数限制为【1，1】。</para>
        /// <para>零钱：CFT</para>
        /// <para>示例值：ICBC_CREDIT </para>
        /// <para>可为null</para>
        /// </summary>
        public string[] limit_pay { get; set; }

        /// <summary>
        /// 指定银行卡BIN
        /// <para>指定银行卡bin付款的交易可核销/使用代金券，当批次限定了指定银行卡时方可生效</para>
        /// <para>可为null</para>
        /// </summary>
        public Limit_Card limit_card { get; set; }

        /// <summary>
        /// 支付方式
        /// <para>允许指定支付方式的交易才可核销/使用代金券，不填则默认“不限”。 枚举值：   MICROAPP：小程序支付    APPPAY：APP支付    PPAY：免密支付    CARD：刷卡支付    FACE：人脸支付    OTHER：其他支付</para>
        /// <para>示例值：["MICROAPP","APPPAY"] </para>
        /// <para>可为null</para>
        /// </summary>
        public string[] trade_type { get; set; }

        /// <summary>
        /// 是否可叠加其他优惠 
        /// <para>允许指定本优惠是否可以和本商户号创建的其他券同时使用，不填则默认允许同时使用。枚举值： true：是 false：否 </para>
        /// <para>示例值：false </para>
        /// <para>可为null</para>
        /// </summary>
        public bool combine_use { get; set; }

        /// <summary>
        /// 可核销商品编码 
        /// <para>包含指定SKU商品编码的交易才可核销/使用代金券：活动商户在交易下单时，需传入用户购买的所有SKU商品编码，当命中代金券中设置的商品编码时可享受优惠。 </para>
        /// <para>校验规则：1、单个商品编码的字符长度为【1，128】2、条目个数限制为【1，50】</para>
        /// <para>示例值：['123321','456654']</para>
        /// <para>可为null</para>
        /// </summary>
        public string[] available_items { get; set; }

        /// <summary>
        /// 不可核销商品编码 
        /// <para>该字段暂未开放 包含指定SKU商品编码的交易不可核销/使用代金券。 </para>
        /// <para>校验规则：1、单个商品编码的字符长度为【1，128】2、条目个数限制为【1，50】</para>
        /// <para>示例值：['789987','56765']</para>
        /// <para>可为null</para>
        /// </summary>
        public string[] unavailable_items { get; set; }

        /// <summary>
        /// 可用商户号 
        /// <para>可用商户的交易才可核销/使用代金券。当营销经费no_cash=false时，可用商户允许填入任何类型的特约商户或普通商户 当营销经费no_cash=ture时，分为以下几种情况： 1、创建商户是普通商户或服务商特约商户(子商户)：可添加本商户号或同品牌商户。</para>
        /// <para>说明：若可用商户中，有特约商户(子商户)，那么特约商户自己发起的交易、以及服务商帮特约商户发起的交易，都可以使用代金券。 2、创建商户是普通服务商：可添加已授权的子商户，详见《申请免充值代金券产品权限》。</para>
        /// <para>说明：特约商户如果有多个服务商，那么服务商为他发起的交易，只要完成了免充值授权，都可以使用代金券；特约商户自己发起的交易不可以使用代金券。 3、创建商户是渠道商、银行服务商或从业机构：可直接添加旗下任意子商户，不需要子商户授权。</para>
        /// <para>校验规则：条目个数限制为【1，50】</para>
        /// <para>示例值：['9856000','9856111']</para>
        /// </summary>
        public string[] available_merchants { get; set; }

        #region 子数据类型
        public class Coupon_Available_Time
        {

            /// <summary>
            /// 含参构造函数
            /// </summary>
            /// <param name="fix_available_time">固定时间段可用 <para>允许指定券在特殊时间段生效。当设置固定时间段可用时不可设置领取后N天有效</para><para>该字段暂未开放</para><para></para><para>可为null</para></param>
            /// <param name="second_day_available">领取后N天有效  <para>领取后，券的开始时间为领券后第二天，如7月1日领券，那么在7月2日00:00:00开始。当设置领取后N天有效时，不可设置固定时间段可用。枚举值：true：是false：否</para><para>该字段暂未开放</para><para>示例值：false</para><para>可为null</para></param>
            /// <param name="available_time_after_receive">领取后有效时间  <para>领取后，券的结束时间为领取N天后，如设置领取后7天有效，那么7月1日领券，在7月7日23:59:59失效（在可用时间内计算失效时间，若券还未到领取后N天，但是已经到了可用结束时间，那么也会过期）领取后有效时间，单位：分钟。</para><para>该字段暂未开放</para><para>示例值：1440</para><para>可为null</para></param>
            public Coupon_Available_Time(Fix_Available_Time fix_available_time, bool second_day_available, uint available_time_after_receive)
            {
                this.fix_available_time = fix_available_time;
                this.second_day_available = second_day_available;
                this.available_time_after_receive = available_time_after_receive;
            }

            /// <summary>
            /// 无参构造函数
            /// </summary>
            public Coupon_Available_Time()
            {
            }

            /// <summary>
            /// 固定时间段可用
            /// <para>允许指定券在特殊时间段生效。当设置固定时间段可用时不可设置领取后N天有效</para>
            /// <para>该字段暂未开放</para>
            /// <para></para>
            /// <para>可为null</para>
            /// </summary>
            public Fix_Available_Time fix_available_time { get; set; }

            /// <summary>
            /// 领取后N天有效 
            /// <para>领取后，券的开始时间为领券后第二天，如7月1日领券，那么在7月2日00:00:00开始。当设置领取后N天有效时，不可设置固定时间段可用。 枚举值：   true：是   false：否 </para>
            /// <para>该字段暂未开放</para>
            /// <para>示例值：false </para>
            /// <para>可为null</para>
            /// </summary>
            public bool second_day_available { get; set; }

            /// <summary>
            /// 领取后有效时间 
            /// <para>领取后，券的结束时间为领取N天后，如设置领取后7天有效，那么7月1日领券，在7月7日23:59:59失效（在可用时间内计算失效时间，若券还未到领取后N天，但是已经到了可用结束时间，那么也会过期）领取后有效时间，单位：分钟。</para>
            /// <para>该字段暂未开放</para>
            /// <para>示例值：1440 </para>
            /// <para>可为null</para>
            /// </summary>
            public uint available_time_after_receive { get; set; }

            #region 子数据类型
            public class Fix_Available_Time
            {

                /// <summary>
                /// 含参构造函数
                /// </summary>
                /// <param name="available_week_day">可用星期数  <para>允许指定每周固定星期数生效，0代表周日生效，1代表周一生效，以此类推；不填则代表在可用时间内周一至周日都生效。</para><para>该字段暂未开放</para><para>示例值：1，2</para><para>可为null</para></param>
                /// <param name="begin_time">当天开始时间  <para>允许指定特殊生效星期数中的具体生效的时间段。当天开始时间，单位：秒。</para><para>该字段暂未开放</para><para>示例值：0</para><para>可为null</para></param>
                /// <param name="end_time">当天结束时间  <para>允许指定特殊生效星期数中的具体生效的时间段。当天结束时间，单位：秒，默认为23点59分59秒。</para><para>该字段暂未开放</para><para>示例值：3600</para><para>可为null</para></param>
                public Fix_Available_Time(uint available_week_day, uint begin_time, uint end_time)
                {
                    this.available_week_day = available_week_day;
                    this.begin_time = begin_time;
                    this.end_time = end_time;
                }

                /// <summary>
                /// 无参构造函数
                /// </summary>
                public Fix_Available_Time()
                {
                }

                /// <summary>
                /// 可用星期数 
                /// <para>允许指定每周固定星期数生效，0代表周日生效，1代表周一生效，以此类推；不填则代表在可用时间内周一至周日都生效。 </para>
                /// <para>该字段暂未开放</para>
                /// <para>示例值：1，2 </para>
                /// <para>可为null</para>
                /// </summary>
                public uint available_week_day { get; set; }

                /// <summary>
                /// 当天开始时间 
                /// <para>允许指定特殊生效星期数中的具体生效的时间段。当天开始时间，单位：秒。 </para>
                /// <para>该字段暂未开放</para>
                /// <para>示例值：0 </para>
                /// <para>可为null</para>
                /// </summary>
                public uint begin_time { get; set; }

                /// <summary>
                /// 当天结束时间 
                /// <para>允许指定特殊生效星期数中的具体生效的时间段。当天结束时间，单位：秒，默认为23点59分59秒。 </para>
                /// <para>该字段暂未开放</para>
                /// <para>示例值：3600 </para>
                /// <para>可为null</para>
                /// </summary>
                public uint end_time { get; set; }

            }


            #endregion
        }

        public class Fixed_Normal_Coupon
        {

            /// <summary>
            /// 含参构造函数
            /// </summary>
            /// <param name="coupon_amount">面额  <para>面额，单位：分。</para><para>校验规则：1、必须为整数2、必须大于1分且小于等于1000元</para><para>示例值：100</para></param>
            /// <param name="transaction_minimum">门槛  <para>使用券金额门槛，单位：分。若指定可核销商品编码，门槛则为可核销商品部分的消费金额，而不是订单的消费金额。</para><para>校验规则：使用门槛必须大于优惠金额</para><para>示例值：100</para></param>
            public Fixed_Normal_Coupon(ulong coupon_amount, ulong transaction_minimum)
            {
                this.coupon_amount = coupon_amount;
                this.transaction_minimum = transaction_minimum;
            }

            /// <summary>
            /// 无参构造函数
            /// </summary>
            public Fixed_Normal_Coupon()
            {
            }

            /// <summary>
            /// 面额 
            /// <para>面额，单位：分。</para>
            /// <para>校验规则：1、必须为整数2、必须大于1分且小于等于1000元</para>
            /// <para>示例值：100 </para>
            /// </summary>
            public ulong coupon_amount { get; set; }

            /// <summary>
            /// 门槛 
            /// <para>使用券金额门槛，单位：分。 若指定可核销商品编码，门槛则为可核销商品部分的消费金额，而不是订单的消费金额。</para>
            /// <para>校验规则：使用门槛必须大于优惠金额</para>
            /// <para>示例值：100 </para>
            /// </summary>
            public ulong transaction_minimum { get; set; }

        }

        public class Limit_Card
        {

            /// <summary>
            /// 含参构造函数
            /// </summary>
            /// <param name="name">银行卡名称  <para>将在微信支付收银台向用户展示，最多4个中文汉字</para><para>示例值：精粹白金</para><para>可为null</para></param>
            /// <param name="bin">指定卡BIN  <para>使用指定卡BIN的银行卡支付方可享受优惠，按json格式</para><para>特殊规则：单个卡BIN的字符长度为【6,9】,条目个数限制为【1,10】。</para><para>示例值：['62123456','62123457']</para><para>可为null</para></param>
            public Limit_Card(string name, string[] bin)
            {
                this.name = name;
                this.bin = bin;
            }

            /// <summary>
            /// 无参构造函数
            /// </summary>
            public Limit_Card()
            {
            }

            /// <summary>
            /// 银行卡名称 
            /// <para>将在微信支付收银台向用户展示，最多4个中文汉字 </para>
            /// <para>示例值：精粹白金 </para>
            /// <para>可为null</para>
            /// </summary>
            public string name { get; set; }

            /// <summary>
            /// 指定卡BIN 
            /// <para>使用指定卡BIN的银行卡支付方可享受优惠，按json格式</para>
            /// <para>特殊规则：单个卡BIN的字符长度为【6,9】,条目个数限制为【1,10】。</para>
            /// <para>示例值：['62123456','62123457'] </para>
            /// <para>可为null</para>
            /// </summary>
            public string[] bin { get; set; }

        }


        #endregion
    }


    #endregion
}

