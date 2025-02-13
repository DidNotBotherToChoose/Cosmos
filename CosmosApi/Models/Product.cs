using static System.Net.Mime.MediaTypeNames;

namespace CosmosApi.Models
{

    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public bool IsDeleted { get; set; }

       
        public Category Category { get; set; }

       
        public ICollection<Image> Images { get; set; }

      
        public ICollection<StockMovement> StockMovements { get; set; }
    }

}
