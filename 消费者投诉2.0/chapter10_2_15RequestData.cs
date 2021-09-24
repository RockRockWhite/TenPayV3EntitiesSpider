public class chapter10_2_15RequestData
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="complaint_id">投诉单号 <para>path投诉单对应的投诉单号</para><para>示例值：20201820200101126</para></param>
/// <param name="complainted_mchid">被诉商户号 <para>body投诉单对应的被诉商户号</para><para>示例值：1900012181</para></param>
        public chapter10_2_15RequestData(string complaint_id, string complainted_mchid)
        {
        this.complaint_id = complaint_id;
this.complainted_mchid = complainted_mchid;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public chapter10_2_15RequestData()
        {
        }
        
        /// <summary>
        /// 投诉单号
        /// <para>path投诉单对应的投诉单号 </para>
 /// <para>示例值：20201820200101126</para>
        /// </summary>
        public string complaint_id { get; set; }

        /// <summary>
        /// 被诉商户号
        /// <para>body投诉单对应的被诉商户号 </para>
 /// <para>示例值：1900012181</para>
        /// </summary>
        public string complainted_mchid { get; set; }

}

