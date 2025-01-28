using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Venda:Produto, User, Empregado
    {
        public int? VendaId { get; set; }
        public DateTime? Data { get; set; }

    }
}
