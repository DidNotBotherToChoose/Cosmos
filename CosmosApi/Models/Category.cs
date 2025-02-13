﻿namespace CosmosApi.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryCode { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }

}