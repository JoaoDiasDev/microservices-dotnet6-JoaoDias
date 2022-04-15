using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopJoaoDias.IndentityServer.MainModule;

namespace ShopJoaoDias.IndentityServer.Views.Device;

[SecurityHeaders]
[Authorize]
public class SuccessModel : PageModel
{
    public void OnGet()
    {
    }
}