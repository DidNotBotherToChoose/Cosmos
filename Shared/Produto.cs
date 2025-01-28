using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Produto: Categoria
    {
        public int ProdutoId { get; set; }
        public string? ProdutoNome { get; set; }
        public string? ProdutoDescricao { get; set; }
        public decimal Preco { get; set; }
        public int Stock { get; set; }

    }
}
