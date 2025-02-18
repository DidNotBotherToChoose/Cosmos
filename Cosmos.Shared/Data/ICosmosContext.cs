using Cosmos.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Cosmos.Shared.Data
{
    public interface ICosmosContext
    {
        public DbSet<Product> Products { get; set; }

    }
}
