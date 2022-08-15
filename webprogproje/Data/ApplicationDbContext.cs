using HayvanBarinagiCalisma.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace webprogproje.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Iletisim> Iletisim { get; set; }
        public DbSet<Hayvan> Hayvan { get; set; }
        public DbSet<Tur> Tur { get; set; }
        public DbSet<Cins> Cins { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // any unique string id
            const string ADMIN_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e575";

            const string ADMIN_ID2 = "a18be9c0-aa65-4af8-bd17-00bd9344e576";
            const string ADMIN_ID3 = "a18be9c0-aa65-4af8-bd17-00bd9344e577";

            const string ROLE_ID = "1";
            const string ROLE_ID2 = "2";

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = ROLE_ID,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = ROLE_ID2,
                    Name = "Uye",
                    NormalizedName = "UYE"
                }
            );

            var hasher = new PasswordHasher<CustomUser>();
            builder.Entity<CustomUser>().HasData(
                new CustomUser
                {
                    Id = ADMIN_ID,
                    UserName = "b191210049@sakarya.edu.tr",
                    NormalizedUserName = "B211210354@SAKARYA.EDU.TR",
                    Email = "B211210354@sakarya.edu.tr",
                    NormalizedEmail = "B211210354@SAKARYA.EDU.TR",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123"),
                    SecurityStamp = string.Empty
                }
                
            );

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = ROLE_ID,
                    UserId = ADMIN_ID
                }
                );
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
       
    }
    }
}
