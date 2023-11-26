using System.Security;

namespace WebApi.Models.Permissions
{
    public class PermissionsModel
    {
    }

    public class PermissionsResultMOdel
    {
        /// <summary>
        /// 流水號
        /// </summary>
        public int PermissionsId { get; set; }
        /// <summary>
        /// 權限名稱
        /// </summary>
        public int PermissionsName { get; set; }
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
