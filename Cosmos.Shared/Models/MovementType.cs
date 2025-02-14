using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Shared.Models
{
    public class MovementType
    {
        public int MovementTypeId { get; set; }

        public string Description { get; set; }

        public List<StockMovement> StockMovements { get; set; }
    }
}
