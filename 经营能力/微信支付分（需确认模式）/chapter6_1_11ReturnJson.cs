public class chapter6_1_11ReturnJson
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="businessType">跳转类型  <para>打开的业务类型。</para><para>示例值：wxpayScoreUse</para></param>
/// <param name="extMsg">返回信息 <para>支付分返回的业务数据，json格式。</para><para>示例值：见extMsg示例</para></param>
        public chapter6_1_11ReturnJson(string businessType, string extMsg)
        {
        this.businessType = businessType;
this.extMsg = extMsg;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public chapter6_1_11ReturnJson()
        {
        }
        
        /// <summary>
        /// 跳转类型 
        /// <para>打开的业务类型。 </para>
 /// <para>示例值：wxpayScoreUse </para>
        /// </summary>
        public string businessType { get; set; }

        /// <summary>
        /// 返回信息
        /// <para>支付分返回的业务数据，json格式。 </para>
 /// <para>示例值：见extMsg示例 </para>
        /// </summary>
        public string extMsg { get; set; }

}

