namespace WebApi.Models.Share
{
    /// <summary>
    /// 請求條件-模型
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RequestModel<T>
    {
        /// <summary>
        /// 請求條件
        /// </summary>
        public T Data { get; set; }
    }
}
