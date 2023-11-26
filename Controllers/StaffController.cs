using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Share;
using WebApi.Models.Staff;
using WebApi.Modules;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StaffController : ControllerBase
    {
        private readonly ILogger<StaffController> _logger;
        private readonly StaffModule _staffModule;
        public StaffController(ILogger<StaffController> logger,StaffModule staff)
        {
            _logger = logger;
            _staffModule = staff;
        }

        [HttpGet(Name = "Get")]
        public ResponseListDataModel<StaffModel> Get(StaffRequestModel staff)
        {
            _logger.Log(LogLevel.Information, "GetStaff");
            var res = _staffModule.GetStaff(staff);
            return new ResponseListDataModel<StaffModel>();
        }

        [HttpPost(Name = "Create")]
        public ResponseModel Create()
        {
            return new ResponseModel();
        }

        [HttpPatch(Name = "Modify")]
        public ResponseModel Modify(StaffModifyModel staff)
        {
           
            return new ResponseModel();
        }

    }
}
