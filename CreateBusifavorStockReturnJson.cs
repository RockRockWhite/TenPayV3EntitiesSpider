public class CreateBusifavorStockReturnJson
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="stock_id">批次号  <para>微信为每个商家券批次分配的唯一ID。</para><para>示例值：98065001</para></param>
/// <param name="create_time">创建时间  <para>创建时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss表示时分秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC8小时，即北京时间）。例如：2015-05-20T13:29:35.+08:00表示，北京时间2015年5月20日13点29分35秒。</para><para>示例值：2015-05-20T13:29:35+08:00</para></param>
        public CreateBusifavorStockReturnJson(string stock_id, string create_time)
        {
        this.stock_id = stock_id;
this.create_time = create_time;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public CreateBusifavorStockReturnJson()
        {
        }
        
        /// <summary>
        /// 批次号 
        /// <para>微信为每个商家券批次分配的唯一ID。 </para>
 /// <para>示例值：98065001 </para>
        /// </summary>
        public string stock_id { get; set; }

        /// <summary>
        /// 创建时间 
        /// <para>创建时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss表示时分秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35.+08:00表示，北京时间2015年5月20日 13点29分35秒。</para>
 /// <para>示例值：2015-05-20T13:29:35+08:00 </para>
        /// </summary>
        public string create_time { get; set; }

}

