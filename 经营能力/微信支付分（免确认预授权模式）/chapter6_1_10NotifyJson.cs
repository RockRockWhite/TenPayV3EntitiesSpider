public class chapter6_1_10NotifyJson
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="appid">公众账号ID  <para>调用授权服务接口提交的公众账号ID。</para><para>示例值：wxd678efh567hg6787</para></param>
/// <param name="mchid">商户号  <para>调用授权服务接口提交的商户号。</para><para>示例值：1230000109</para></param>
/// <param name="out_request_no">商户签约单号  <para>调用授权服务接口提交的商户请求唯一标识（新签约的用户，且在授权签约中上传了该字段，则在解约授权回调通知中有返回）。</para><para>示例值：1234323JKHDFE1243252</para><para>可为null</para></param>
/// <param name="service_id">服务ID  <para>调用授权服务接口提交的服务ID。</para><para>示例值：1234323JKHDFE1243252</para></param>
/// <param name="openid">用户标识  <para>微信用户在商户对应appid下的唯一标识。</para><para>示例值：oUpF8uMuAJO_M2pxb1Q9zNjWeS6o</para></param>
/// <param name="user_service_status">回调状态  <para>1、USER_OPEN_SERVICE：授权成功 2、USER_CLOSE_SERVICE：解除授权成功</para><para>示例值：USER_OPEN_SERVICE</para><para>可为null</para></param>
/// <param name="openorclose_time">服务开启/解除授权时间  <para>服务开启/解除授权成功时间。</para><para>示例值：20180225112233</para><para>可为null</para></param>
/// <param name="authorization_code">授权协议号 <para>商户系统内部授权协议号，预授权时返回，非预授权不返回</para><para>示例值：1275342195190894594</para><para>可为null</para></param>
        public chapter6_1_10NotifyJson(string appid, string mchid, string out_request_no, string service_id, string openid, string user_service_status, string openorclose_time, string authorization_code)
        {
        this.appid = appid;
this.mchid = mchid;
this.out_request_no = out_request_no;
this.service_id = service_id;
this.openid = openid;
this.user_service_status = user_service_status;
this.openorclose_time = openorclose_time;
this.authorization_code = authorization_code;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public chapter6_1_10NotifyJson()
        {
        }
        
        /// <summary>
        /// 公众账号ID 
        /// <para>调用授权服务接口提交的公众账号ID。 </para>
 /// <para>示例值：wxd678efh567hg6787 </para>
        /// </summary>
        public string appid { get; set; }

        /// <summary>
        /// 商户号 
        /// <para>调用授权服务接口提交的商户号。 </para>
 /// <para>示例值：1230000109 </para>
        /// </summary>
        public string mchid { get; set; }

        /// <summary>
        /// 商户签约单号 
        /// <para>调用授权服务接口提交的商户请求唯一标识（新签约的用户，且在授权签约中上传了该字段，则在解约授权回调通知中有返回）。 </para>
 /// <para>示例值：1234323JKHDFE1243252 </para>
        /// <para>可为null</para>
        /// </summary>
        public string out_request_no { get; set; }

        /// <summary>
        /// 服务ID 
        /// <para>调用授权服务接口提交的服务ID。 </para>
 /// <para>示例值：1234323JKHDFE1243252 </para>
        /// </summary>
        public string service_id { get; set; }

        /// <summary>
        /// 用户标识 
        /// <para>微信用户在商户对应appid下的唯一标识。 </para>
 /// <para>示例值：oUpF8uMuAJO_M2pxb1Q9zNjWeS6o </para>
        /// </summary>
        public string openid { get; set; }

        /// <summary>
        /// 回调状态 
        /// <para>1、USER_OPEN_SERVICE：授权成功  2、USER_CLOSE_SERVICE：解除授权成功 </para>
 /// <para>示例值：USER_OPEN_SERVICE </para>
        /// <para>可为null</para>
        /// </summary>
        public string user_service_status { get; set; }

        /// <summary>
        /// 服务开启/解除授权时间 
        /// <para>服务开启/解除授权成功时间。 </para>
 /// <para>示例值：20180225112233 </para>
        /// <para>可为null</para>
        /// </summary>
        public string openorclose_time { get; set; }

        /// <summary>
        /// 授权协议号
        /// <para>商户系统内部授权协议号，预授权时返回，非预授权不返回</para>
 /// <para>示例值：1275342195190894594</para>
        /// <para>可为null</para>
        /// </summary>
        public string authorization_code { get; set; }

}

