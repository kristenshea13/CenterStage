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
        }
    }
}
