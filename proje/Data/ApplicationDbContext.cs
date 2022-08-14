using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using proje.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace proje.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Foto> Foto { get; set; }
        public DbSet<DiscountedProducts> DiscountedProducts { get; set; }
        public DbSet<Campaign> Campaign { get; set; }
        public DbSet<Category> Categori { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
