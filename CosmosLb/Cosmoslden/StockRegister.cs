using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosLb.Cosmoslden
{
 public class StockRegister
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime Data { get; set; }
        public bool Type { get; set; } // true para entrada, false para saída
    }
}
