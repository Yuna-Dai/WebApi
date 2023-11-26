namespace WebApi.Models.Staff
{
    public class StaffViewModel
    {
    }

    /// <summary>
    /// 更新員工資料-模型
    /// </summary>
    public class StaffModifyModel
    {
        /// <summary>
        /// 工廠流水號
        /// </summary>
        public int FactoryId { get; set; }
        /// <summary>
        /// 部門流水號
        /// </summary>
        public int DepartmentId { get; set; }
        /// <summary>
        /// 員工編號
        /// </summary>
        public int StaffNumber { get; set; }
        /// <summary>
        /// 員工姓名
        /// </summary>
        public required string StaffName { get; set; }
        /// <summary>
        /// 密碼
        /// </summary>
        public required string Password { get; set; }
        /// <summary>
        /// 更新時間
        /// </summary>
        public DateTime Updatedate { get; set; }
    }

    /// <summary>
    /// 建立員工資料-模型
    /// </summary>
    public class StaffCreateModel
    {
        /// <summary>
        /// 工廠流水號
        /// </summary>
        public int FactoryId { get; set; }
        /// <summary>
        /// 部門流水號
        /// </summary>
        public int DepartmentId { get; set; }
        /// <summary>
        /// 員工編號
        /// </summary>
        public int StaffNumber { get; set; }
        /// <summary>
        /// 員工姓名
        /// </summary>
        public required string StaffName { get; set; }
        /// <summary>
        /// 建立時間
        /// </summary>
        public DateTime CreateDate { get; set; }
    }

    /// <summary>
    /// 查詢員工資料-模型
    /// </summary>
    public class StaffRequestModel
    {
        public string? StaffNumber { get; set; }
        public string? StaffName { get; set; }
    }

    /// <summary>
    /// 回傳員工資料-模型
    /// </summary>
    public class StaffResponseModel
    {
        /// <summary>
        /// 流水號
        /// </summary>
        public int StaffId { get; set; }
        /// <summary>
        /// 工廠流水號
        /// </summary>
        public int FactoryId { get; set; }
        /// <summary>
        /// 部門流水號
        /// </summary>
        public int DepartmentId { get; set; }
        /// <summary>
        /// 員工編號
        /// </summary>
        public int StaffNumber { get; set; }
        /// <summary>
        /// 員工姓名
        /// </summary>
        public required string StaffName { get; set; }
        /// <summary>
        /// 密碼
        /// </summary>
        public required string Password { get; set; }
        /// <summary>
        /// 是否啟用
        /// </summary>
        public bool IsUse { get; set; }
        /// <summary>
        /// 是否禁用
        /// </summary>
        public bool IsBan { get; set; }
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
