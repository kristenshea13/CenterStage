using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CenterStage.Data.Models;

namespace CenterStage.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CenterStage.Data.Models.Class> Class { get; set; }
        public DbSet<CenterStage.Data.Models.StudentInfo> StudentInfo { get; set; }
        public DbSet<StudentRegistration> StudentRegistration { get; set; }
    }
}
