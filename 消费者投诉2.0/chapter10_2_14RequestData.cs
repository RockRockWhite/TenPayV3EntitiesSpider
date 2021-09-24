public class chapter10_2_14RequestData
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="complaint_id">投诉单号 <para>path投诉单对应的投诉单号</para><para>示例值：200201820200101080076610000</para></param>
/// <param name="complainted_mchid">被诉商户号 <para>body投诉单对应的被诉商户号</para><para>示例值：1900012181</para></param>
/// <param name="response_content">回复内容 <para>body具体的投诉处理方案，限制200个字符以内。</para><para>示例值：已与用户沟通解决</para></param>
/// <param name="response_images">回复图片 <para>body传入调用商户上传反馈图片接口返回的media_id，最多上传4张图片凭证</para><para>示例值：file23578_21798531.jpg</para><para>可为null</para></param>
        public chapter10_2_14RequestData(string complaint_id, string complainted_mchid, string response_content, string[] response_images)
        {
        this.complaint_id = complaint_id;
this.complainted_mchid = complainted_mchid;
this.response_content = response_content;
this.response_images = response_images;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public chapter10_2_14RequestData()
        {
        }
        
        /// <summary>
        /// 投诉单号
        /// <para>path投诉单对应的投诉单号 </para>
 /// <para>示例值：200201820200101080076610000</para>
        /// </summary>
        public string complaint_id { get; set; }

        /// <summary>
        /// 被诉商户号
        /// <para>body投诉单对应的被诉商户号 </para>
 /// <para>示例值：1900012181</para>
        /// </summary>
        public string complainted_mchid { get; set; }

        /// <summary>
        /// 回复内容
        /// <para>body具体的投诉处理方案，限制200个字符以内。 </para>
 /// <para>示例值：已与用户沟通解决</para>
        /// </summary>
        public string response_content { get; set; }

        /// <summary>
        /// 回复图片
        /// <para>body传入调用商户上传反馈图片接口返回的media_id，最多上传4张图片凭证 </para>
 /// <para>示例值：file23578_21798531.jpg</para>
        /// <para>可为null</para>
        /// </summary>
        public string[] response_images { get; set; }

}

