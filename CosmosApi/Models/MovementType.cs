namespace CosmosApi.Models
{
    public class MovementType
    {
        public int MovementTypeId { get; set; }
        public string Description { get; set; }

        public ICollection<StockMovement> StockMovements { get; set; }
    }

}