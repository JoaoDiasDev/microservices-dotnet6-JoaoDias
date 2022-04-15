using Microsoft.AspNetCore.Identity;

namespace ShopJoaoDias.IndentityServer.Model.Context
{
    public class ApplicationUser : IdentityUser
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
    }
}
