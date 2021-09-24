public class chapter6_1_2ReturnJson
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="apply_permissions_token">预授权token <para>用于跳转到微信侧小程序授权数据,跳转到微信侧小程序传入，时效性为1小时</para><para>示例值：apply_permissions_token</para></param>
        public chapter6_1_2ReturnJson(string apply_permissions_token)
        {
        this.apply_permissions_token = apply_permissions_token;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public chapter6_1_2ReturnJson()
        {
        }
        
        /// <summary>
        /// 预授权token
        /// <para>用于跳转到微信侧小程序授权数据,跳转到微信侧小程序传入，时效性为1小时 </para>
 /// <para>示例值：apply_permissions_token</para>
        /// </summary>
        public string apply_permissions_token { get; set; }

}

