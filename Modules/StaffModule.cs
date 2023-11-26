using WebApi.Models.Share;
using WebApi.Models.Staff;
using WebApi.Modules.Interface;

namespace WebApi.Modules
{
    public class StaffModule : IStaffInterface
    {       
            

        /// <summary>
        /// 霰得員工資料-模組
        /// </summary>
        /// <returns></returns>
       
        public ResponseListDataModel<StaffResponseModel> GetStaff(StaffRequestModel staffRequestModel)
        {
            var response = new ResponseListDataModel<StaffResponseModel>();

            response.Data = new List<StaffResponseModel>();

            return response;
        }

        /// <summary>
        /// 修改員工資料=模組
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        public ResponseModel ModifyStaff(StaffModifyModel staff)
        {
            return new ResponseModel();
        }
    }

}
