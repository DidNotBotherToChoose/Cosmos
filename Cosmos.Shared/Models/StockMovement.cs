using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Shared.Models
{
    public class StockMovement
    {
        public int StockMovementId { get; set; }

        public int MovementTypeId { get; set; }
        public MovementType MovementType { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public int UpdatedByUserId { get; set; }
        public User UpdatedByStockMovementId { get; set; }

        public int Delta { get; set; }
    }

}
