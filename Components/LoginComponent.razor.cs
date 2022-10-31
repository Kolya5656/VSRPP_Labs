using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;

namespace VSRPP_labs.Components;

public partial class LoginComponent_razor : ComponentBase
{
    public LoginComponent_razor()
    {
        LoginData = new LoginViewModel();
    }

    public LoginViewModel LoginData { get; set; }

    protected Task LoginAsync()
    {
        return Task.CompletedTask;
    }
}

public class LoginViewModel
{
    [Required]
    [StringLength(50, ErrorMessage = "Too long")]
    public string UserName { get; set; }

    [Required]
    public string Password { get; set; }
}