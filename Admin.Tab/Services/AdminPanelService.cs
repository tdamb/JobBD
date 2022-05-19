using DataModel.CustomModels;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Components;


namespace Admin.Tab.Services
{
    public class AdminPanelService : IAdminPanelService
    {
        private readonly HttpClient _httpClient;

        public AdminPanelService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<ResponseModel> AdminLogin(LoginModel loginModel)
        {
            return await _httpClient.PostAsJsonAsync<LoginModel>("api/admin/AdminLogin", loginModel);
        }
    }
}