public class chapter10_2_13RequestData
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="complaint_id">投诉单号 <para>path投诉单对应的投诉单号</para><para>示例值：200201820200101080076610000</para></param>
        public chapter10_2_13RequestData(string complaint_id)
        {
        this.complaint_id = complaint_id;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public chapter10_2_13RequestData()
        {
        }
        
        /// <summary>
        /// 投诉单号
        /// <para>path投诉单对应的投诉单号 </para>
 /// <para>示例值：200201820200101080076610000</para>
        /// </summary>
        public string complaint_id { get; set; }

}

