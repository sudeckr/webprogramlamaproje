
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using seyahat.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Text;

namespace seyahat.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Admin> Admin { get; set; }
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<AnaSayfa> AnaSayfa { get; set; }
        public DbSet<Hakkimizda> Hakkimizda { get; set; }
        public DbSet<Iletisim> Iletisim { get; set; }
        public DbSet<Yorumlar> Yorumlar { get; set; }
        public DbSet<Blog> Blog { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}





