namespace WebApi.Models.Factory
{
    public class FactoryModel
    {
    }

    public class FactoryResultModel
    {
        /// <summary>
        /// 流水號
        /// </summary>
        public int FactoryId { get; set; }
        /// <summary>
        /// 廠名
        /// </summary>
        public int FactoryName { get; set; }
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
