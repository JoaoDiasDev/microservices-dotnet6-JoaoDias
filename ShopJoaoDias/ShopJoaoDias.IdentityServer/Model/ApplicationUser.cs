using Microsoft.AspNetCore.Identity;

namespace ShopJoaoDias.IdentityServer.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
    }
}
