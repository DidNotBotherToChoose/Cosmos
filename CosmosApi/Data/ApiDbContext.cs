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
            modelBuilder.Entity<User>().HasKey(x => x.UserId);
            modelBuilder.Entity<User>()
                .HasMany(x => x.CreatedByUser)
                .WithOne(x => x.CreatedByUser)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<User>()
                .HasMany(x => x.UpdatedByUser)
                .WithOne(x => x.UpdatedByUser)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<StockMovement>().HasKey(x => x.StockMovementId);
            modelBuilder.Entity<StockMovement>()
                .HasOne(x => x.CreatedByUser)
                .WithMany(x => x.CreatedByUser)
                .HasForeignKey(x => x.CreatedByUserId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<StockMovement>()
                .HasOne(x => x.UpdatedByUser)
                .WithMany(x => x.UpdatedByUser)
                .HasForeignKey(x => x.UpdatedByUserId)
                .OnDelete(DeleteBehavior.NoAction);
            

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SQL1002.site4now.net;Initial Catalog=db_ab244b_cosmos;User Id=db_ab244b_cosmos_admin;Password=e9P&s8fKsgRZ9G*7;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder); 
        }
        

    }
}
