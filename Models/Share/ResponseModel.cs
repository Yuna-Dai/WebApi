namespace WebApi.Models.Share
{
    /// <summary>
    /// 回傳-模型
    /// </summary>
    public class ResponseModel
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool IsSuccess { get; set; }
        /// <summary>
        /// 訊息代碼
        /// </summary>
        public int MessageCode { get; set; }
        /// <summary>
        /// 訊息
        /// </summary>
        public string Message { get; set; }
    }


    /// <summary>
    /// 回傳單筆資料-模型
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ResponseDataModel<T> : ResponseModel
    {
        /// <summary>
        /// 單筆資料
        /// </summary>
        public T Data { get; set; }
    }

    /// <summary>
    /// 回傳多筆資料-模型
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ResponseListDataModel<T> : ResponseModel
    {
        /// <summary>
        /// 多筆資料
        /// </summary>
        public List<T> Data { get; set; }
    }
}
