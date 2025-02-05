using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.CosmosIden
{
    public class Produto : Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int CategoriaId { get; set; }
        public decimal PrecoCusto { get; set; }
        public int Stock { get; set; }
        public bool IsCompleted { get; set; } // soft delete
        public Categoria Categoria { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
