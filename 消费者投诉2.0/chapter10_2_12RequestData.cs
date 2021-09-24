public class chapter10_2_12RequestData
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="complaint_id">投诉单号 <para>path投诉单对应的投诉单号</para><para>示例值：200201820200101080076610000</para></param>
/// <param name="limit">分页大小 <para>query设置该次请求返回的最大协商历史条数，范围[1,300]，不传默认为100。注：如遇到提示“当前查询结果数据量过大”，是回包触发微信支付下行数据包大小限制，请缩小入参limit并重试。</para><para>示例值：50</para><para>可为null</para></param>
/// <param name="offset">分页开始位置 <para>query该次请求的分页开始位置，从0开始计数，例如offset=10，表示从第11条记录开始返回，不传默认为0。。</para><para>示例值：10</para><para>可为null</para></param>
        public chapter10_2_12RequestData(string complaint_id, int limit, int offset)
        {
        this.complaint_id = complaint_id;
this.limit = limit;
this.offset = offset;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public chapter10_2_12RequestData()
        {
        }
        
        /// <summary>
        /// 投诉单号
        /// <para>path投诉单对应的投诉单号 </para>
 /// <para>示例值：200201820200101080076610000</para>
        /// </summary>
        public string complaint_id { get; set; }

        /// <summary>
        /// 分页大小
        /// <para>query设置该次请求返回的最大协商历史条数，范围[1,300]，不传默认为100。 注：如遇到提示“当前查询结果数据量过大”，是回包触发微信支付下行数据包大小限制，请缩小入参limit并重试。</para>
 /// <para>示例值：50</para>
        /// <para>可为null</para>
        /// </summary>
        public int limit { get; set; }

        /// <summary>
        /// 分页开始位置
        /// <para>query该次请求的分页开始位置，从0开始计数，例如offset=10，表示从第11条记录开始返回，不传默认为0。。 </para>
 /// <para>示例值：10</para>
        /// <para>可为null</para>
        /// </summary>
        public int offset { get; set; }

}

