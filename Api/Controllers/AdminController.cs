using DataModel.CustomModels;
using Logic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;


namespace Api.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : Controller
    {
        private readonly IWebHostEnvironment env;
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService, IWebHostEnvironment _env)
        {
            this._adminService = adminService;
            this.env = _env;
        }

        [HttpPost]
        [Route("AdminLogin")]
        public IActionResult AdminLogin(LoginModel loginModel)
        {
            var data = _adminService.AdminLogin(loginModel);
            return Ok(data);
        }
    }
}