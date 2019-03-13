﻿using Microsoft.AspNetCore.Identity;

namespace CenterStage.Data.Models
{
    public class AppRole : IdentityRole<int>
    {
        public AppRole(){}

        public AppRole(string name)
        {
            Name = name;
        }
    }
}