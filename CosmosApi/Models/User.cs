namespace CosmosApi.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsStaff { get; set; }
        public string Password { get; set; }

        public ICollection<StockMovement> CreatedByUser { get; set; }
        public ICollection<StockMovement> UpdatedByUser { get; set; }
    }

}