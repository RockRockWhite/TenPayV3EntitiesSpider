public class chapter8_4_1ReturnJson
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="guide_id">服务人员ID <para>服务人员在服务人员系统中的唯一标识</para><para>示例值：LLA3WJ6DSZUfiaZDS79FH5Wm5m4X69TBic</para></param>
        public chapter8_4_1ReturnJson(string guide_id)
        {
        this.guide_id = guide_id;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public chapter8_4_1ReturnJson()
        {
        }
        
        /// <summary>
        /// 服务人员ID
        /// <para>服务人员在服务人员系统中的唯一标识 </para>
 /// <para>示例值：LLA3WJ6DSZUfiaZDS79FH5Wm5m4X69TBic</para>
        /// </summary>
        public string guide_id { get; set; }

}

