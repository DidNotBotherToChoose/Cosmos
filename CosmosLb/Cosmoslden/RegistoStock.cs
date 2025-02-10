using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosLb.Cosmoslden
{
 public class RegistoStock
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data { get; set; }
        public bool Tipo { get; set; } // true para entrada, false para saída
    }
}
