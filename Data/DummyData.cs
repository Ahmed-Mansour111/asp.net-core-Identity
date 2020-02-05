using IdentityCus.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCus.Data
{
    public class DummyData
    {
        public static async Task Initialize(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager)
        {
            context.Database.EnsureCreated();
            string adminId1 = "";
            string adminId2 = "";
            string role1 = "Admin";
            string desc1 = "This is The Administrator role";
            string role2 = "Member";
            string desc2 = "This is The Member role";
            string password = "P@ssword";
            if(await roleManager.FindByNameAsync(role1)==null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role1, desc1, DateTime.Now));
            }

            if (await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role2, desc2, DateTime.Now));
            }

            if (await roleManager.FindByNameAsync("ahmed@ahmed.ahmed") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "ahmed@ahmed.ahmed",
                    Email = "ahmed@ahmed.ahmed",
                    FirstName = "ahmed",
                    LastName = "mansour",
                    Country = "Egypt",
                    City = "Cairo"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId1 = user.Id;
            }

            if (await roleManager.FindByNameAsync("mansour@mansour.mansour") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "mansour@mansour.mansour",
                    Email = "mansour@mansour.mansour",
                    FirstName = "mansour",
                    LastName = "ahmed",
                    Country = "Canda",
                    City = "Toranto"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId2 = user.Id;
            }

            if (await roleManager.FindByNameAsync("aa@aa.aa") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "aa@aa.aa",
                    Email = "aa@aa.aa",
                    FirstName = "mansour",
                    LastName = "ahmed",
                    Country = "Canda",
                    City = "Toranto"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
                
            }
            if (await roleManager.FindByNameAsync("bb@bb.bb") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "bb@bb.bb",
                    Email = "bb@bb.bb",
                    FirstName = "mansour",
                    LastName = "ahmed",
                    Country = "Canda",
                    City = "Toranto"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }

            }

        }
    }
}
