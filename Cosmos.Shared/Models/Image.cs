using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Shared.Models
{
    public class Image
    {
        public int ImageId { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public string URL { get; set; }
    }
}
