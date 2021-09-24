public class chapter8_8_2ReturnJson
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="id">停车入场id <para>车主服务为商户分配的入场id</para><para>示例值：5K8264ILTKCH16CQ250</para></param>
/// <param name="out_parking_no">商户入场id <para>商户侧入场标识id，在同一个商户号下唯一</para><para>示例值：212434321</para></param>
/// <param name="plate_number">车牌号 <para>车牌号，仅包括省份+车牌，不包括特殊字符。</para><para>示例值：粤B888888</para></param>
/// <param name="plate_color">车牌颜色 <para>车牌颜色，枚举值：BLUE：蓝色GREEN：绿色YELLOW：黄色BLACK：黑色WHITE：白色LIMEGREEN：黄绿色</para><para>示例值：BLUE</para></param>
/// <param name="start_time">入场时间 <para>入场时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss表示时分秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35+08:00表示，北京时间2015年5月20日 13点29分35秒。</para><para>示例值：2017-08-26T10:43:39+08:00</para></param>
/// <param name="parking_name">停车场名称 <para>所在停车位车场的名称</para><para>示例值：欢乐海岸停车场</para></param>
/// <param name="free_duration">免费时长 <para>停车场的免费停车时长，单位为秒</para><para>示例值：3600</para></param>
/// <param name="state">停车入场状态 <para>本次入场车牌的服务状态，NORMAL：正常状态，可以使用微信支付分停车服务，BLOCKED：不可用状态，暂时不可以使用微信支付分停车服务</para><para>示例值：NORMAL</para></param>
/// <param name="block_reason">不可用状态描述 <para>block服务状态描述，返回车牌状态为BLOCKED，会返回该字段，描述具体BLOCKED的原因，PAUSE：已暂停微信支付分停车服务；OVERDUE：已授权签约但欠费，不能提供服务,OUT_SERVICE：车牌未开通微信支付分停车服务，EVALUATION_FAILED：综合评估未通过，用户支付分不可用的情况，会返回该状态。</para><para>示例值：PAUSE</para><para>可为null</para></param>
        public chapter8_8_2ReturnJson(string id, string out_parking_no, string plate_number, string plate_color, string start_time, string parking_name, int free_duration, string state, string block_reason)
        {
        this.id = id;
this.out_parking_no = out_parking_no;
this.plate_number = plate_number;
this.plate_color = plate_color;
this.start_time = start_time;
this.parking_name = parking_name;
this.free_duration = free_duration;
this.state = state;
this.block_reason = block_reason;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public chapter8_8_2ReturnJson()
        {
        }
        
        /// <summary>
        /// 停车入场id
        /// <para>车主服务为商户分配的入场id </para>
 /// <para>示例值：5K8264ILTKCH16CQ250</para>
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 商户入场id
        /// <para>商户侧入场标识id，在同一个商户号下唯一 </para>
 /// <para>示例值：212434321</para>
        /// </summary>
        public string out_parking_no { get; set; }

        /// <summary>
        /// 车牌号
        /// <para>车牌号，仅包括省份+车牌，不包括特殊字符。 </para>
 /// <para>示例值：粤B888888</para>
        /// </summary>
        public string plate_number { get; set; }

        /// <summary>
        /// 车牌颜色
        /// <para>车牌颜色，枚举值： BLUE：蓝色 GREEN：绿色 YELLOW：黄色 BLACK：黑色 WHITE：白色 LIMEGREEN：黄绿色 </para>
 /// <para>示例值：BLUE</para>
        /// </summary>
        public string plate_color { get; set; }

        /// <summary>
        /// 入场时间
        /// <para>入场时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss表示时分秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35+08:00表示，北京时间2015年5月20日 13点29分35秒。 </para>
 /// <para>示例值：2017-08-26T10:43:39+08:00</para>
        /// </summary>
        public string start_time { get; set; }

        /// <summary>
        /// 停车场名称
        /// <para>所在停车位车场的名称 </para>
 /// <para>示例值：欢乐海岸停车场</para>
        /// </summary>
        public string parking_name { get; set; }

        /// <summary>
        /// 免费时长
        /// <para>停车场的免费停车时长，单位为秒 </para>
 /// <para>示例值：3600</para>
        /// </summary>
        public int free_duration { get; set; }

        /// <summary>
        /// 停车入场状态
        /// <para>本次入场车牌的服务状态， NORMAL：正常状态，可以使用微信支付分停车服务， BLOCKED：不可用状态，暂时不可以使用微信支付分停车服务 </para>
 /// <para>示例值：NORMAL</para>
        /// </summary>
        public string state { get; set; }

        /// <summary>
        /// 不可用状态描述
        /// <para>block服务状态描述，返回车牌状态为BLOCKED，会返回该字段，描述具体BLOCKED的原因， PAUSE：已暂停微信支付分停车服务； OVERDUE：已授权签约但欠费，不能提供服务, OUT_SERVICE：车牌未开通微信支付分停车服务， EVALUATION_FAILED：综合评估未通过，用户支付分不可用的情况，会返回该状态。 </para>
 /// <para>示例值：PAUSE</para>
        /// <para>可为null</para>
        /// </summary>
        public string block_reason { get; set; }

}

