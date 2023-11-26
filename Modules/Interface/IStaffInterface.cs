using WebApi.Models.Staff;

namespace WebApi.Modules.Interface
{
    public interface IStaffInterface
    {
        /// <summary>
        /// 取得員工資料-介面
        /// </summary>
        /// <param name="staffQueryModel"></param>
        /// <returns></returns>
         StaffResultModel GetStaff(StaffQueryModel staffQueryModel);
       
    }
}
