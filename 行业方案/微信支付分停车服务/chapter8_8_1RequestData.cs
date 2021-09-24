public class chapter8_8_1RequestData
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="appid">应用ID <para>queryappid是商户在微信申请公众号或移动应用成功后分配的账号ID，登录平台为mp.weixin.qq.com或open.weixin.qq.com</para><para>示例值：wxcbda96de0b165486</para></param>
/// <param name="plate_number">车牌号 <para>query车牌号，仅包括省份+车牌，不包括特殊字符。</para><para>示例值：粤B888888</para></param>
/// <param name="plate_color">车牌颜色 <para>query车牌颜色，枚举值：BLUE：蓝色GREEN：绿色YELLOW：黄色BLACK：黑色WHITE：白色LIMEGREEN：黄绿色</para><para>示例值：BLUE</para></param>
/// <param name="openid">用户标识 <para>query用户在商户对应appid下的唯一标识</para><para>示例值：oUpF8uMuAJOM2pxb1Q</para></param>
        public chapter8_8_1RequestData(string appid, string plate_number, string plate_color, string openid)
        {
        this.appid = appid;
this.plate_number = plate_number;
this.plate_color = plate_color;
this.openid = openid;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public chapter8_8_1RequestData()
        {
        }
        
        /// <summary>
        /// 应用ID
        /// <para>queryappid是商户在微信申请公众号或移动应用成功后分配的账号ID，登录平台为mp.weixin.qq.com或open.weixin.qq.com </para>
 /// <para>示例值：wxcbda96de0b165486</para>
        /// </summary>
        public string appid { get; set; }

        /// <summary>
        /// 车牌号
        /// <para>query车牌号，仅包括省份+车牌，不包括特殊字符。 </para>
 /// <para>示例值：粤B888888</para>
        /// </summary>
        public string plate_number { get; set; }

        /// <summary>
        /// 车牌颜色
        /// <para>query车牌颜色，枚举值： BLUE：蓝色 GREEN：绿色 YELLOW：黄色 BLACK：黑色 WHITE：白色 LIMEGREEN：黄绿色 </para>
 /// <para>示例值：BLUE</para>
        /// </summary>
        public string plate_color { get; set; }

        /// <summary>
        /// 用户标识
        /// <para>query用户在商户对应appid下的唯一标识 </para>
 /// <para>示例值：oUpF8uMuAJOM2pxb1Q</para>
        /// </summary>
        public string openid { get; set; }

}

