using EnumStringValues;

namespace WebApi.Enums
{
    enum MessageCode : ushort
    {
        [StringValue("成功")]
        Success = 20001,
        [StringValue("新增成功")]
        CreateSuccess = 20002,
        [StringValue("更新成功")]
        ModifySuccess = 20003,
        [StringValue("刪除成功")]
        DeleteSuccess = 20004,

        [StringValue("失敗")]
        Fail = 30001,
        [StringValue("新增失敗")]
        CreateFail = 30002,
        [StringValue("更新失敗")]
        ModifyFail = 30003,
        [StringValue("刪除失敗")]
        DeleteFail = 30004,

        [StringValue("錯誤")]
        Error = 40001,
        [StringValue("權限錯誤")]
        PermissionsError = 40002,
        [StringValue("密碼錯誤")]
        PasswordError = 40003,
        [StringValue("連線錯誤")]
        ConnectionError = 40004,
        [StringValue("參數錯誤")]
        ParameterError = 40005,
        [StringValue("資料錯誤")]
        DataError = 40006,

        [StringValue("伺服器錯誤")]
        ServerError = 50001,
        [StringValue("例外錯誤")]
        ExcptionError = 50002

    }
}
