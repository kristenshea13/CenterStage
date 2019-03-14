using CenterStage.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CenterStage.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AppUser>().Ignore(e => e.FullName);
        }

        public DbSet<CenterStage.Data.Models.Class> Class { get; set; }
        public DbSet<CenterStage.Data.Models.StudentInfo> StudentInfo { get; set; }
        public DbSet<StudentRegistration> StudentRegistration { get; set; }
        
    }
}