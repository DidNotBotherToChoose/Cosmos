namespace CosmosApi.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public int ProductId { get; set; }
        public string URL { get; set; }

        public Product Product { get; set; }
    }

}
