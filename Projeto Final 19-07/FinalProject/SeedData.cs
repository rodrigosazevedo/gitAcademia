using FinalProject.Models;
using Microsoft.AspNetCore.Identity;

namespace FinalProject
{
    public static class SeedData
    {
        public static void Seed(UserManager<Person> userManager, RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }
        
        public static void SeedUsers(UserManager<Person> userManager)
        {
            if (userManager.FindByNameAsync("admin").Result == null)
            {
                var user = new Person
                {
                    UserName = "admin",
                    Email = "admin@localhost"
                };
                var result = userManager.CreateAsync(user,"password").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user,"Administrator").Wait();
                }
            }    
        }
   

        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Administrator").Result)
            {
                var role = new IdentityRole
                {
                    Name = "Administrator"
                };
                roleManager.CreateAsync(role);
            }

            if (!roleManager.RoleExistsAsync("Doctor").Result)
            {
                var role = new IdentityRole
                {
                    Name = "Doctor"
                };
                roleManager.CreateAsync(role);
            }

            if (!roleManager.RoleExistsAsync("Patient").Result)
            {
                var role = new IdentityRole
                {
                    Name = "Patient"
                };
                roleManager.CreateAsync(role);
            }

        }

        internal static void Seed(bool v, object rikeroleManager)
        {
            throw new NotImplementedException();
        }

        internal static void Seed(bool v1, bool v2)
        {
            throw new NotImplementedException();
        }
    }
}
