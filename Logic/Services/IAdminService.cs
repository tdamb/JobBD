using DataModel.CustomModels;

namespace Logic.Services
{
    public interface IAdminService
    {
        ResponseModel AdminLogin(LoginModel loginModel);
    }
}