using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.CosmosIden;
using Microsoft.EntityFrameworkCore;


namespace Cosmos.Data
{
    public class CosmosContext : DbContext, ICosmosContext
    {

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<RegistoStocks> Stocks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SQL1002.site4now.net;Initial Catalog=db_ab244b_cosmos;User Id=db_ab244b_cosmos_admin;Password=e9P&s8fKsgRZ9G*7");
        }

    }
}
