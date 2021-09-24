public class chapter8_4_3RequestData
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="store_id">门店ID <para>query门店在微信支付商户平台的唯一标识</para><para>示例值：1234</para><para></para></param>
/// <param name="userid">企业微信的员工ID <para>query员工在商户企业微信通讯录使用的唯一标识，企业微信商家可传入该字段查询单个服务人员信息；不传则查询整个门店下的服务人员信息</para><para>示例值：robert</para><para></para><para>可为null</para></param>
/// <param name="mobile">手机号码 <para>query服务人员通过小程序注册时填写的手机号码，企业微信/个人微信商家可传入该字段查询单个服务人员信息；不传则查询整个门店下的服务人员信息。该字段需进行加密处理，加密方法详见敏感信息加密说明</para><para>特殊规则：加密前字段长度限制为32个字节</para><para>示例值：str2WoWy8uUiWM7xahvNv0lV3C+nn3t4QlKNnyr+iwlk2FoMcn/lxrR6YdKKFI6NFJkC5oyvzNwc1MDzIgjLR0W6bJKiwWeOV3Fp0x+VIoRDONal1Mgb6VTYg7lvACEqdwmVkvbt4/oEWaWP62njMGGe0fMiBSAvao3LrcsOwDvN3E9kiaw5XQZMP/rUdWTFfy5THuohcQobGMrxclHKAnwAHU8CWfkziW5crUc3Z83uMVcFQu38y9EcWR12FJ3jip5nyVKiqCF4iDSN+JRXjWsWlqTZ0Y8Q+piBCS5ACusK6nz7mKQeypi9fKjAggRfvNFPf/bNxPvork4mMVgZkA==</para><para></para><para>可为null</para></param>
/// <param name="work_id">工号 <para>query服务人员通过小程序注册时填写的工号，个人微信商家可传入该字段查询单个服务人员信息；不传则查询整个门店下的服务人员信息</para><para>示例值：robert</para><para></para><para>可为null</para></param>
/// <param name="limit">最大资源条数 <para>query商家自定义字段，该次请求可返回的最大资源条数，不大于10</para><para>示例值：5</para><para></para><para>可为null</para></param>
/// <param name="offset">请求资源起始位置 <para>query商家自定义字段，该次请求资源的起始位置，默认值为0</para><para>示例值：0</para><para></para><para>可为null</para></param>
        public chapter8_4_3RequestData(int store_id, string userid, string mobile, string work_id, int limit, int offset)
        {
        this.store_id = store_id;
this.userid = userid;
this.mobile = mobile;
this.work_id = work_id;
this.limit = limit;
this.offset = offset;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public chapter8_4_3RequestData()
        {
        }
        
        /// <summary>
        /// 门店ID
        /// <para>query门店在微信支付商户平台的唯一标识 </para>
 /// <para>示例值：1234</para>
 /// <para></para>
        /// </summary>
        public int store_id { get; set; }

        /// <summary>
        /// 企业微信的员工ID
        /// <para>query员工在商户企业微信通讯录使用的唯一标识，企业微信商家可传入该字段查询单个服务人员信息；不传则查询整个门店下的服务人员信息 </para>
 /// <para>示例值：robert</para>
 /// <para></para>
        /// <para>可为null</para>
        /// </summary>
        public string userid { get; set; }

        /// <summary>
        /// 手机号码
        /// <para>query服务人员通过小程序注册时填写的手机号码，企业微信/个人微信商家可传入该字段查询单个服务人员信息；不传则查询整个门店下的服务人员信息。该字段需进行加密处理，加密方法详见敏感信息加密说明 </para>
 /// <para>特殊规则：加密前字段长度限制为32个字节</para>
 /// <para>示例值：str2WoWy8uUiWM7xahvNv0lV3C+nn3t4QlKNnyr+iwlk2FoMcn/lxrR6YdKKFI6NFJkC5oyvzNwc1MDzIgjLR0W6bJKiwWeOV3Fp0x+VIoRDONal1Mgb6VTYg7lvACEqdwmVkvbt4/oEWaWP62njMGGe0fMiBSAvao3LrcsOwDvN3E9kiaw5XQZMP/rUdWTFfy5THuohcQobGMrxclHKAnwAHU8CWfkziW5crUc3Z83uMVcFQu38y9EcWR12FJ3jip5nyVKiqCF4iDSN+JRXjWsWlqTZ0Y8Q+piBCS5ACusK6nz7mKQeypi9fKjAggRfvNFPf/bNxPvork4mMVgZkA==</para>
 /// <para></para>
        /// <para>可为null</para>
        /// </summary>
        public string mobile { get; set; }

        /// <summary>
        /// 工号
        /// <para>query服务人员通过小程序注册时填写的工号，个人微信商家可传入该字段查询单个服务人员信息；不传则查询整个门店下的服务人员信息 </para>
 /// <para>示例值：robert</para>
 /// <para></para>
        /// <para>可为null</para>
        /// </summary>
        public string work_id { get; set; }

        /// <summary>
        /// 最大资源条数
        /// <para>query商家自定义字段，该次请求可返回的最大资源条数，不大于10 </para>
 /// <para>示例值：5</para>
 /// <para></para>
        /// <para>可为null</para>
        /// </summary>
        public int limit { get; set; }

        /// <summary>
        /// 请求资源起始位置
        /// <para>query商家自定义字段，该次请求资源的起始位置，默认值为0 </para>
 /// <para>示例值：0</para>
 /// <para></para>
        /// <para>可为null</para>
        /// </summary>
        public int offset { get; set; }

}

