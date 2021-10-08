using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PeopleMVC.Data.DataManagement.User;

namespace PeopleMVC.Data.Database
{
    public class UserContext : IdentityDbContext<ApplicationUser>
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            IdentityRole roleAdmin = new IdentityRole()
            {
                Id = "438db5c8-0513-43a0-a84c-cd416c4e3a54",
                Name = "Admin",
                NormalizedName = "ADMIN"
            };
            IdentityRole roleUser = new IdentityRole()
            {
                Id = "0948bea6-fb82-49c9-8cd8-fec213fe8e8a",
                Name = "User",
                NormalizedName = "USER"
            };

            builder.Entity<IdentityRole>().HasData(
              roleAdmin, roleUser);


            PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();

            ApplicationUser admin = new ApplicationUser
            {
                Id = "6ce8a888-ad60-493f-a351-4fb416b81284",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Birthday = DateTime.Now,
                FirstName = "Donald",
                LastName = "Duck",
                Email = "admin@admin.com"
            };

            admin.PasswordHash = passwordHasher.HashPassword(admin, "admin");

            builder.Entity<ApplicationUser>().HasData(
                admin
            );

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = roleAdmin.Id,
                    UserId = admin.Id
                }
            ,
                new IdentityUserRole<string>
                {
                    RoleId = roleUser.Id,
                    UserId = admin.Id
                }
            );
        }
    }
}
