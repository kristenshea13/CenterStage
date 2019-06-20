using CenterStage.Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CenterStage.Data
{
    public static class ApplicationDbContextExtensions
    {
        public static UserManager<AppUser> UserManager { get; set; }


        public static void EnsureSeeded(this ApplicationDbContext context)
        {
            if (UserManager.FindByEmailAsync("kristenshea@rocketmail.com").GetAwaiter().GetResult() == null)
            {
                var user = new AppUser
                {
                    FirstName = "Kristen",
                    LastName = "Shea",
                    UserName = "kristenshea@rocketmail.com",
                    Email = "kristenshea@rocketmail.com",
                    EmailConfirmed = true,
                    LockoutEnabled = false
                };

                UserManager.CreateAsync(user, "P@ssword1").GetAwaiter().GetResult();



            }

            if (UserManager.FindByEmailAsync("kristenlshea82@gmail.com").GetAwaiter().GetResult() == null)
            {
                var user2 = new AppUser
                {
                    FirstName = "Karen",
                    LastName = "Shea",
                    UserName = "kristenlshea82@gmail.com",
                    Email = "kristenlshea82@gmail.com",
                    EmailConfirmed = true,
                    LockoutEnabled = false

                };

                UserManager.CreateAsync(user2, "P@ssword2").GetAwaiter().GetResult();

            }


            if (UserManager.FindByEmailAsync("kstar61@live.com").GetAwaiter().GetResult() == null)
            {
                var user3 = new AppUser
                {
                    FirstName = "Kristen",
                    LastName = "Shea",
                    UserName = "kstar61@live.com",
                    Email = "kstar61@live.com",
                    EmailConfirmed = true,
                    LockoutEnabled = false

                };

                UserManager.CreateAsync(user3, "P@ssword3").GetAwaiter().GetResult();

            }



        }
    }
}
