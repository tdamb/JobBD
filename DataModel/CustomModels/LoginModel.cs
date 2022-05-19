using System.ComponentModel.DataAnnotations;

namespace DataModel.CustomModels;

public class LoginModel
{
    public string UserKey { get; set; }
    public string Name { get; set; }
    [Required(ErrorMessage = "Email is Required")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Password is Required")]
    public string Password { get; set; }
}