using Microsoft.EntityFrameworkCore;
using ProductApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Persistence.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option):base(option)
        {

        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() {Id=Guid.NewGuid(),ProductName="Pen",Value=10,Quantity=100 },
                new Product() { Id = Guid.NewGuid(), ProductName = "Paper", Value = 100, Quantity = 100 },
                new Product() { Id = Guid.NewGuid(), ProductName = "Eraser", Value = 5, Quantity = 25 },
                new Product() { Id = Guid.NewGuid(), ProductName = "Backpack", Value = 500, Quantity = 1 }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
