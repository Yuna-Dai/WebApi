namespace WebApi.Models.Title
{
    public class TitleModel
    {
    }

    /// <summary>
    /// 回傳頭銜資料-模型
    /// </summary>
    public class TitleResultModel
    {
        /// <summary>
        /// 流水號
        /// </summary>
        public int TitleId { get; set; }
        /// <summary>
        /// 頭銜名稱
        /// </summary>
        public string TitleName { get; set; }
        /// <summary>
        /// 建立時間
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 更新時間
        /// </summary>
        public DateTime UpdateDate { get; set; }
    }
}
