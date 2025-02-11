using CosmosApi.Models;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;

namespace CosmosApi.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<StockMovement> StockMovements { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<MovementType> MovementTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relacionamento entre StockMovement e User
            modelBuilder.Entity<StockMovement>()
                .HasOne(sm => sm.CreatedByUser) 
                .WithMany() 
                .HasForeignKey("CreatedByUserId")  
                .OnDelete(DeleteBehavior.Restrict); 
        }

    }
}
