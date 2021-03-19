using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MusicShopMVC.Data
{
    public class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(IdentityEnums.Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(IdentityEnums.Roles.Usuario.ToString()));
        }
    }
}