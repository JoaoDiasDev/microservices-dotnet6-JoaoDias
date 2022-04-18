using Duende.IdentityServer;
using Duende.IdentityServer.Models;

namespace ShopJoaoDias.IndentityServer.Configuration
{
    public static class IdentityConfiguration
    {
        public const string Admin = "Admin";
        public const string Client = "Client";

        public static IEnumerable<IdentityResource> IdentityResources => new List<IdentityResource>
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Email(),
            new IdentityResources.Profile()
        };

        public static IEnumerable<ApiScope> ApiScopes => new List<ApiScope>
        {
            new("shop_joao_dias", "ShopJoaoDias Server"),
            new("read", "Read data."),
            new("write", "Write data."),
            new("delete", "Delete data."),
        };

        public static IEnumerable<Client> Clients => new List<Client>
        {
            new()
            {
                ClientId = "client",
                ClientSecrets = {new Secret("super_secret_dias".Sha256())},
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                AllowedScopes = {"read", "write", "profile"}
            },

            new()
            {
            ClientId = "shop_joao_dias",
            ClientSecrets = {new Secret("super_secret_dias".Sha256())},
            AllowedGrantTypes = GrantTypes.Code,
            RedirectUris = {"https://localhost:4430/signin-oidc"},
            PostLogoutRedirectUris = {"https://localhost:4430/signout-callback-oidc"},
            AllowedScopes = new List<string>
            {
                IdentityServerConstants.StandardScopes.OpenId,
                IdentityServerConstants.StandardScopes.Profile,
                IdentityServerConstants.StandardScopes.Email,
            }
            }
        };
    }
}
