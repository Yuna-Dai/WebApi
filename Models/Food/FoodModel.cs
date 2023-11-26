namespace WebApi.Models.Food
{
    public class FoodModel
    {
    }
    /// <summary>
    /// 更新食物資料-模型
    /// </summary>
    public class FoodUpdateModel
    {
        /// <summary>
        /// 中文食物名稱
        /// </summary>
        public string FoodNameCn { get; set; }
        /// <summary>
        /// 英文食物名稱
        /// </summary>
        public string? FoodNameEn { get; set; }
        /// <summary>
        /// 是否啟用
        /// </summary>
        public bool IsUse { get; set; }
        /// <summary>
        /// 建立時間
        /// </summary>
        public DateTime CreateDate { get; set; }
    }
    /// <summary>
    /// 回傳食物資料-模型
    /// </summary>
    public class FoodResultModel
    {
        /// <summary>
        /// 流水號
        /// </summary>
        public int FoodId { get; set; }
        /// <summary>
        /// 中文食物名稱
        /// </summary>
        public string FoodNameCn { get; set; }
        /// <summary>
        /// 英文食物名稱
        /// </summary>
        public string? FoodNameEn { get; set; }
        /// <summary>
        /// 是否啟用
        /// </summary>
        public bool IsUse { get; set; }
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
