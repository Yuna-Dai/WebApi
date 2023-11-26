using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApi.Models.Order
{
    public class OrderModel { }

    /// <summary>
    /// 新增訂購資料-模型
    /// </summary>
    public class OrderInsertModel
    {
        /// <summary>
        /// 日期
        /// </summary>
        public Date Date { get; set; }
        /// <summary>
        /// food流水號
        /// </summary>
        public int FoodId { get; set; }
        /// <summary>
        /// 數量
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// 是否取消
        /// </summary>
        public bool IsCancel { get; set; }
        /// <summary>
        /// 訂購時間
        /// </summary>
        public DateTime OrderTime { get; set; }
        /// <summary>
        /// 原因
        /// </summary>
        public string? Reason { get; set; }
        /// <summary>
        /// 建立時間
        /// </summary>
        public DateTime CreateDate { get; set; }
    }

    /// <summary>
    /// 更新訂購資料-模型
    /// </summary>
    public class OrderUpdateModel
    {
        /// <summary>
        /// 日期
        /// </summary>
        public Date Date { get; set; }
        /// <summary>
        /// food流水號
        /// </summary>
        public int FoodId { get; set; }
        /// <summary>
        /// 數量
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// 是否取消
        /// </summary>
        public bool IsCancel { get; set; }
        /// <summary>
        /// 訂購時間
        /// </summary>
        public DateTime OrderTime { get; set; }
        /// <summary>
        /// 原因
        /// </summary>
        public string? Reason { get; set; }       
        /// <summary>
        /// 更新時間
        /// </summary>
        public DateTime UpdateDate { get; set; }
    }

    /// <summary>
    /// 回傳訂購資料-模型
    /// </summary>
    public class OrderResultModel
    {
        /// <summary>
        /// 日期
        /// </summary>
        public Date Date { get; set; }
        /// <summary>
        /// food流水號
        /// </summary>
        public int FoodId { get; set; }
        /// <summary>
        /// 數量
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// 是否取消
        /// </summary>
        public bool IsCancel { get; set; }
        /// <summary>
        /// 訂購時間
        /// </summary>
        public DateTime OrderTime { get; set; }
        /// <summary>
        /// 原因
        /// </summary>
        public string? Reason { get; set; }
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
