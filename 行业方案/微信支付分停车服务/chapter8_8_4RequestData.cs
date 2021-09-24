public class chapter8_8_4RequestData
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="out_trade_no">商户订单号 <para>path商户系统内部订单号，只能是数字、大小写字母，且在同一个商户号下唯一</para><para>示例值：20150806125346</para></param>
        public chapter8_8_4RequestData(string out_trade_no)
        {
        this.out_trade_no = out_trade_no;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public chapter8_8_4RequestData()
        {
        }
        
        /// <summary>
        /// 商户订单号
        /// <para>path商户系统内部订单号，只能是数字、大小写字母，且在同一个商户号下唯一 </para>
 /// <para>示例值：20150806125346</para>
        /// </summary>
        public string out_trade_no { get; set; }

}

