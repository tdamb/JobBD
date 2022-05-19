using DataModel.CustomModels;

namespace Logic.Services
{
    public class AdminService : IAdminService
    {
        public ResponseModel AdminLogin(LoginModel loginModel)
        {
            ResponseModel responseModel = new ResponseModel();
            responseModel.Status = false;
            responseModel.Message = "Incorrect Id / Password";
            return responseModel;
        }
    }
}