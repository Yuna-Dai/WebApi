namespace WebApi.Models.Department
{
    public class DepartmentModel
    {
    }
    public class DepartmentResultModel
    {
        /// <summary>
        /// 流水號
        /// </summary>
        public int DepartmentId { get; set; }
        /// <summary>
        /// 部門名稱
        /// </summary>
        public int DepartmentName { get; set; }
        /// <summary>
        /// 是否啟用
        /// </summary>
        public int IsUse { get; set; }
        /// <summary>
        /// 建立時間
        /// </summary>
        public int CreateDate { get; set; }
        /// <summary>
        /// 更新時間
        /// </summary>
        public int UpdateDate { get; set; }

    }
}
