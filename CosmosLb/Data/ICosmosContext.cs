using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CosmosLb.Cosmoslden;
using Microsoft.EntityFrameworkCore;

namespace CosmosLb.Data
{
   public interface ICosmosContext
    {
        public DbSet<Product> Products { get; set; }

    }
}
