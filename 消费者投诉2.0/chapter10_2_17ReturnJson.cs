public class chapter10_2_17ReturnJson
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="media_data">媒体文件数据 <para>媒体文件数据</para></param>
        public chapter10_2_17ReturnJson(Media_Data media_data)
        {
        this.media_data = media_data;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public chapter10_2_17ReturnJson()
        {
        }
        
        /// <summary>
        /// 媒体文件数据
        /// <para>媒体文件数据</para>
        /// </summary>
        public Media_Data media_data { get; set; }

#region 子数据类型
public class Media_Data
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="chunk">返回包体二进制数据流 <para>返回包体的二进制数据流，注意不是整个实体的数据，在断点续传的支持下可以返回部分数据</para><para>可为null</para></param>
/// <param name="content_type">返回数据包的内容格式 <para>如果不填写，将使用application/octet-stream作为Content-Type返回</para><para>可为null</para></param>
/// <param name="etag">实体标识 <para>用于描述实体标识，非必填项</para><para>可为null</para></param>
/// <param name="filename">返回包体的文件名 <para>返回包体使用Content-Disposition指定回包文件名</para><para>可为null</para></param>
/// <param name="first_pos">断点续传请求的起始位置 <para>支持断点续传请求时，此值可以从包头的Range中获取</para><para>可为null</para></param>
/// <param name="support_partial_content">是否需要支持断点续传 <para>启用支持断点续传，将解析Range包头，并在回包中添加Content-Range标识分块位置信息</para><para>可为null</para></param>
/// <param name="total_size">数据实体的总大小 <para>注意此值并非返回包体大小，对于端点续传的请求，此值必须是大于等于分片大小的</para><para>可为null</para></param>
        public Media_Data(string chunk, string content_type, string etag, string filename, int first_pos, bool support_partial_content, int total_size)
        {
        this.chunk = chunk;
this.content_type = content_type;
this.etag = etag;
this.filename = filename;
this.first_pos = first_pos;
this.support_partial_content = support_partial_content;
this.total_size = total_size;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Media_Data()
        {
        }
        
        /// <summary>
        /// 返回包体二进制数据流
        /// <para>返回包体的二进制数据流，注意不是整个实体的数据，在断点续传的支持下可以返回部分数据 </para>
        /// <para>可为null</para>
        /// </summary>
        public string chunk { get; set; }

        /// <summary>
        /// 返回数据包的内容格式
        /// <para>如果不填写，将使用application/octet-stream作为Content-Type返回</para>
        /// <para>可为null</para>
        /// </summary>
        public string content_type { get; set; }

        /// <summary>
        /// 实体标识
        /// <para>用于描述实体标识，非必填项</para>
        /// <para>可为null</para>
        /// </summary>
        public string etag { get; set; }

        /// <summary>
        /// 返回包体的文件名
        /// <para>返回包体使用Content-Disposition指定回包文件名</para>
        /// <para>可为null</para>
        /// </summary>
        public string filename { get; set; }

        /// <summary>
        /// 断点续传请求的起始位置
        /// <para>支持断点续传请求时，此值可以从包头的Range中获取</para>
        /// <para>可为null</para>
        /// </summary>
        public int first_pos { get; set; }

        /// <summary>
        /// 是否需要支持断点续传
        /// <para>启用支持断点续传，将解析Range包头，并在回包中添加Content-Range标识分块位置信息</para>
        /// <para>可为null</para>
        /// </summary>
        public bool support_partial_content { get; set; }

        /// <summary>
        /// 数据实体的总大小
        /// <para>注意此值并非返回包体大小，对于端点续传的请求，此值必须是大于等于分片大小的</para>
        /// <para>可为null</para>
        /// </summary>
        public int total_size { get; set; }

}


#endregion
}

