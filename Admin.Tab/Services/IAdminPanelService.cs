using DataModel.CustomModels;

namespace Admin.Tab.Services
{
    public interface IAdminPanelService
    {
        Task<ResponseModel> AdminLogin(LoginModel loginModel);
    }
}