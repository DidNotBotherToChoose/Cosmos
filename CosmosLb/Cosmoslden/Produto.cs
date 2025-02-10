using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosLb.Cosmoslden
{
   public class Produto : RegistoStock
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int CategoriaId { get; set; }
        public decimal PrecoCusto { get; set; }
        public int Stock { get; set; }
        public bool IsCompleted { get; set; } // soft delete
        

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

    }
}
