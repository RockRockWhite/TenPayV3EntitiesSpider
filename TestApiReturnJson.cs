public class TestApiRequestData
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="prepay_id ">预支付交易会话标识  <para>数字和字母。微信生成的预支付会话标识，用于后续接口调用使用，该值有效期为2小时。</para><para>示例值：wx201410272009395522657a690389285100</para><para>可为null</para></param>
        public TestApiRequestData(string prepay_id )
        {
        this.prepay_id  = prepay_id ;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public TestApiRequestData()
        {
        }
        
        /// <summary>
        /// 预支付交易会话标识 
        /// <para>数字和字母。微信生成的预支付会话标识，用于后续接口调用使用，该值有效期为2小时。 </para>
 /// <para>示例值：wx201410272009395522657a690389285100 </para>
        /// <para>可为null</para>
        /// </summary>
        public string prepay_id  { get; set; }

}

