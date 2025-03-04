﻿using Cosmos.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace Cosmos.WebApplication
{
    public interface IWebApi
    {
        [Get("/products")]
        Task<List<Product>> GetAllProducts();
        [Get("/categories")]
        Task<List<Category>> GetAllCategories();

        [Post("/saveproduct")]
        Task<HttpResponseMessage> SaveProduct([FromBody] Product product);

        [Get("/product/{id}")]
        Task<Product> GetProduct(int id);

        [Put("/updateproduct")]
        Task<HttpResponseMessage> UpdateProduct([FromBody] Product product);

        //[Post("/addproduct")]
        //Task<HttpResponseMessage> AddProduct([FromBody] Product product);

        [Delete("/deleteproduct")]
        Task<HttpResponseMessage> DeleteProduct(int id);

    }
}
