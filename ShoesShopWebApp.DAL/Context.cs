using ShoesShopWebApp.DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoesShopWebApp.DAL
{
    public class Context : DbContext
    {
        public Context() { }

        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Product> Product { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Brand> Brand { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=ShoesShopDB;Trusted_Connection=True;"); //Windows Authencation
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)  { }
    }
}
