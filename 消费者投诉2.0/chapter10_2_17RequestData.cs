public class chapter10_2_17RequestData
{

        /// <summary>
        /// 含参构造函数
        /// </summary>
/// <param name="media_id">媒体文件标识Id <para>path微信返回的媒体文件标识Id</para><para>示例值：ChsyMDAyMDA1MjAyMTA3MjIxNzAwMDAxMzIwNzIYACD/9I6IBigBMAE4AQ==</para></param>
        public chapter10_2_17RequestData(string media_id)
        {
        this.media_id = media_id;
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public chapter10_2_17RequestData()
        {
        }
        
        /// <summary>
        /// 媒体文件标识Id
        /// <para>path微信返回的媒体文件标识Id</para>
 /// <para>示例值：ChsyMDAyMDA1MjAyMTA3MjIxNzAwMDAxMzIwNzIYACD/9I6IBigBMAE4AQ==</para>
        /// </summary>
        public string media_id { get; set; }

}

