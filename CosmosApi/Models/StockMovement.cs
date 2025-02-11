namespace CosmosApi.Models
{
    public class StockMovement
    {
        public int StockMovementId { get; set; }
        public int MovementTypeId { get; set; }
        public int ProductId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public int Delta { get; set; }

       
        public Product Product { get; set; }

        public MovementType MovementType { get; set; }

        public User CreatedByUser { get; set; }

        public User UpdatedByUser { get; set; }
    }

}