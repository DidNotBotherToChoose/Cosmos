using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Shared.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; } // soft delete
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
