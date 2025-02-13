﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosLb.Cosmoslden
{
   public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal PrecoCusto { get; set; }
        public int Stock { get; set; }
        public bool IsDeleted { get; set; } // soft delete
        public Categoria Categoria { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

    }
}
