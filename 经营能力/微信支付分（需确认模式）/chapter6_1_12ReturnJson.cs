public class chapter6_1_12ReturnJson
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="err_code">返回码  <para>返回码，由于iOS和Android实现的差异，err_code类型可能为Number或string，所以在判断支付分是否成功返回商户的H5时，需要对err_code做整型化处理。</para><para>示例值：iOS：0Android：'0'</para></param>
/// <param name="err_msg">返回信息  <para>返回信息</para><para>示例值：openBusinessView:ok</para></param>
/// <param name="extraData">业务参数 <para>当err_code为0时，extraData才返回；反之，则不返回。</para><para>可为null</para></param>
        public chapter6_1_12ReturnJson(Number/string[1,32] err_code, string err_msg, ExtraData extraData)
        {
        this.err_code = err_code;
this.err_msg = err_msg;
this.extraData = extraData;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public chapter6_1_12ReturnJson()
        {
        }
        
        /// <summary>
        /// 返回码 
        /// <para>返回码，由于iOS和Android实现的差异，err_code类型可能为Number或string，所以在判断支付分是否成功返回商户的H5时，需要对err_code做整型化处理。 </para>
 /// <para>示例值： iOS：0 Android：'0' </para>
        /// </summary>
        public Number/string[1,32] err_code { get; set; }

        /// <summary>
        /// 返回信息 
        /// <para>返回信息 </para>
 /// <para>示例值：openBusinessView:ok </para>
        /// </summary>
        public string err_msg { get; set; }

        /// <summary>
        /// 业务参数
        /// <para>当err_code为0时，extraData才返回；反之，则不返回。 </para>
        /// <para>可为null</para>
        /// </summary>
        public ExtraData extraData { get; set; }

#region 子数据类型
public class ExtraData
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="query_id">单据查询id  <para>单据查询id，对应【查询订单】接口中入参query_id。</para><para>示例值：XXXXXXXX</para></param>
/// <param name="appid">应用ID  <para>支付分公众账号ID。</para><para>示例值：wxd8f3793ea3b935b8</para></param>
        public ExtraData(string query_id, string appid)
        {
        this.query_id = query_id;
this.appid = appid;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public ExtraData()
        {
        }
        
        /// <summary>
        /// 单据查询id 
        /// <para>单据查询id，对应【查询订单】接口中入参query_id。 </para>
 /// <para>示例值：XXXXXXXX </para>
        /// </summary>
        public string query_id { get; set; }

        /// <summary>
        /// 应用ID 
        /// <para>支付分公众账号ID。</para>
 /// <para>示例值：wxd8f3793ea3b935b8 </para>
        /// </summary>
        public string appid { get; set; }

}


#endregion
}

