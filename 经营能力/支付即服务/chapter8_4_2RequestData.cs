public class chapter8_4_2RequestData
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="guide_id">服务人员ID <para>path服务人员在服务人员系统中的唯一标识</para><para>示例值：LLA3WJ6DSZUfiaZDS79FH5Wm5m4X69TBic</para></param>
/// <param name="out_trade_no">商户订单号 <para>body商户系统内部订单号，要求32个字符内，仅支持使用字母、数字、中划线-、下划线_、竖线|、星号*这些英文半角字符的组合，请勿使用汉字或全角等特殊字符，且在同一个商户号下唯一。</para><para>示例值：20150806125346</para></param>
        public chapter8_4_2RequestData(string guide_id, string out_trade_no)
        {
        this.guide_id = guide_id;
this.out_trade_no = out_trade_no;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public chapter8_4_2RequestData()
        {
        }
        
        /// <summary>
        /// 服务人员ID
        /// <para>path 服务人员在服务人员系统中的唯一标识 </para>
 /// <para>示例值：LLA3WJ6DSZUfiaZDS79FH5Wm5m4X69TBic</para>
        /// </summary>
        public string guide_id { get; set; }

        /// <summary>
        /// 商户订单号
        /// <para>body 商户系统内部订单号，要求32个字符内，仅支持使用字母、数字、中划线-、下划线_、竖线|、星号*这些英文半角字符的组合，请勿使用汉字或全角等特殊字符，且在同一个商户号下唯一。</para>
 /// <para>示例值：20150806125346</para>
        /// </summary>
        public string out_trade_no { get; set; }

}

