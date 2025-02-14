using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Shared.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryCode { get; set; }

        public string Description { get; set; }

        public List<Product> Product { get; set; }
    }
}
