public class chapter10_2_11RequestData
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="limit">分页大小 <para>query设置该次请求返回的最大投诉条数，范围【1,50】,商户自定义字段，不传默认为10。注：如遇到提示“当前查询结果数据量过大”，是回包触发微信支付下行数据包大小限制，请缩小入参limit并重试。</para><para>示例值：5</para><para>可为null</para></param>
/// <param name="offset">分页开始位置 <para>query该次请求的分页开始位置，从0开始计数，例如offset=10，表示从第11条记录开始返回，不传默认为0。</para><para>示例值：10</para><para>可为null</para></param>
/// <param name="begin_date">开始日期 <para>query投诉发生的开始日期，格式为YYYY-MM-DD。注意，查询日期跨度不超过30天，当前查询为实时查询</para><para>示例值：2019-01-01</para></param>
/// <param name="end_date">结束日期 <para>query投诉发生的结束日期，格式为YYYY-MM-DD。注意，查询日期跨度不超过30天，当前查询为实时查询</para><para>示例值：2019-01-01</para></param>
/// <param name="complainted_mchid">被诉商户号 <para>query投诉单对应的被诉商户号。</para><para>示例值：1900012181</para><para>可为null</para></param>
        public chapter10_2_11RequestData(int limit, int offset, string begin_date, string end_date, string complainted_mchid)
        {
        this.limit = limit;
this.offset = offset;
this.begin_date = begin_date;
this.end_date = end_date;
this.complainted_mchid = complainted_mchid;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public chapter10_2_11RequestData()
        {
        }
        
        /// <summary>
        /// 分页大小
        /// <para>query设置该次请求返回的最大投诉条数，范围【1,50】,商户自定义字段，不传默认为10。 注：如遇到提示“当前查询结果数据量过大”，是回包触发微信支付下行数据包大小限制，请缩小入参limit并重试。</para>
 /// <para>示例值：5</para>
        /// <para>可为null</para>
        /// </summary>
        public int limit { get; set; }

        /// <summary>
        /// 分页开始位置
        /// <para>query该次请求的分页开始位置，从0开始计数，例如offset=10，表示从第11条记录开始返回，不传默认为0 。 </para>
 /// <para>示例值：10</para>
        /// <para>可为null</para>
        /// </summary>
        public int offset { get; set; }

        /// <summary>
        /// 开始日期
        /// <para>query投诉发生的开始日期，格式为YYYY-MM-DD。注意，查询日期跨度不超过30天，当前查询为实时查询 </para>
 /// <para>示例值：2019-01-01</para>
        /// </summary>
        public string begin_date { get; set; }

        /// <summary>
        /// 结束日期
        /// <para>query投诉发生的结束日期，格式为YYYY-MM-DD。注意，查询日期跨度不超过30天，当前查询为实时查询 </para>
 /// <para>示例值：2019-01-01</para>
        /// </summary>
        public string end_date { get; set; }

        /// <summary>
        /// 被诉商户号
        /// <para>query投诉单对应的被诉商户号。 </para>
 /// <para>示例值：1900012181</para>
        /// <para>可为null</para>
        /// </summary>
        public string complainted_mchid { get; set; }

}

