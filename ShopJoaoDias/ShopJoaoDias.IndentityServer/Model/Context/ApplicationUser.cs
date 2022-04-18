﻿using Microsoft.AspNetCore.Identity;

namespace ShopJoaoDias.IndentityServer.Model.Context
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
