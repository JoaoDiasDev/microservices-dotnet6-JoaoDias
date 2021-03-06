using IdentityModel;
using Microsoft.AspNetCore.Identity;
using ShopJoaoDias.IdentityServer.Configuration;
using ShopJoaoDias.IdentityServer.Model;
using ShopJoaoDias.IdentityServer.Model.Context;
using System.Security.Claims;

namespace ShopJoaoDias.IdentityServer.Initializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly MySQLContext _context;
        private readonly UserManager<ApplicationUser> _user;
        private readonly RoleManager<IdentityRole> _role;

        public DbInitializer(MySQLContext context, UserManager<ApplicationUser> user, RoleManager<IdentityRole> role)
        {
            _context = context;
            _user = user;
            _role = role;
        }

        public void Initialize()
        {
            if (_role.FindByNameAsync(IdentityConfiguration.Admin).Result != null) return;
            _role.CreateAsync(new IdentityRole(IdentityConfiguration.Admin)).GetAwaiter().GetResult();
            _role.CreateAsync(new IdentityRole(IdentityConfiguration.Client)).GetAwaiter().GetResult();

            ApplicationUser admin = new ApplicationUser()
            {
                UserName = "joaodias-admin",
                Email = "joaodiasworking@gmail.com",
                EmailConfirmed = true,
                PhoneNumber = "+55 (22) 997988054",
                FirstName = "João",
                LastName = "Dias"
            };

            _user.CreateAsync(admin, "JoaoDias123$").GetAwaiter().GetResult();
            _user.AddToRoleAsync(admin, IdentityConfiguration.Admin).GetAwaiter().GetResult();
            var adminClaims = _user.AddClaimsAsync(admin, new Claim[]
            {
                new(JwtClaimTypes.Name, $"{admin.FirstName} {admin.LastName}"),
                new(JwtClaimTypes.GivenName, admin.FirstName),
                new(JwtClaimTypes.FamilyName, admin.LastName),
                new(JwtClaimTypes.Role, IdentityConfiguration.Admin),
            }).Result;

            ApplicationUser client = new ApplicationUser()
            {
                UserName = "joaodias-client",
                Email = "joaodiasworking@gmail.com",
                EmailConfirmed = true,
                PhoneNumber = "+55 (22) 997988054",
                FirstName = "João",
                LastName = "Dias"
            };

            _user.CreateAsync(client, "JoaoDias123$").GetAwaiter().GetResult();
            _user.AddToRoleAsync(client, IdentityConfiguration.Client).GetAwaiter().GetResult();
            var clientClaims = _user.AddClaimsAsync(client, new Claim[]
            {
                new(JwtClaimTypes.Name, $"{client.FirstName} {client.LastName}"),
                new(JwtClaimTypes.GivenName, client.FirstName),
                new(JwtClaimTypes.FamilyName, client.LastName),
                new(JwtClaimTypes.Role, IdentityConfiguration.Client),
            }).Result;
        }
    }
}
