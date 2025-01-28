using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Localidade:Concelho
    {
        public int? LocalidadeId { get; set; }
        public string? LocalidadeNome { get; set; }
    }
}
