using Cosmos.Shared.Data;
using Cosmos.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Cosmos.Data
{
    public class CosmosContext : DbContext, ICosmosContext
    {
        public CosmosContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SQL1002.site4now.net;Initial Catalog=db_ab244b_cosmos;User Id=db_ab244b_cosmos_admin;Password=e9P&s8fKsgRZ9G*7");
        }

    }
}
