using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application;
using JomarHealthCare.Domain.Entities;
using System.Reflection;

namespace JomarHealthCare.Repository.Database
{
    public class MyCareDbContext : IdentityDbContext<ApplicationUser>, IUnitOfWork
    {
        public MyCareDbContext(DbContextOptions<MyCareDbContext> options) : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ApplicationUser>()
               .ToTable("tbl_User");

            modelBuilder.Entity<IdentityRole>()
                .ToTable("tbl_Role");

            modelBuilder.Entity<IdentityUserClaim<string>>()
                .ToTable("tbl_UserClaim");

            modelBuilder.Entity<IdentityUserLogin<string>>()
                .ToTable("tbl_UserLogin");

            modelBuilder.Entity<IdentityRoleClaim<string>>()
                .ToTable("tbl_RoleClaim");

            modelBuilder.Entity<IdentityUserToken<string>>()
                .ToTable("tbl_UserToken");

            modelBuilder.Entity<IdentityUserRole<string>>()
                .ToTable("tbl_UserRole");

            modelBuilder.Entity<StaffPersonalInfo>()
                .ToTable("tbl_StaffPersonalInfo");

            modelBuilder.Entity<StaffEducation>()
                .ToTable("tbl_StaffEducation");

            var typesToRegister = Assembly.Load("JomarHealthCare.Domain");
            modelBuilder.ApplyConfigurationsFromAssembly(typesToRegister);


        }

    }
}
