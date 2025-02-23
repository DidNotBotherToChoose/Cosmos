using Cosmos.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace Cosmos.WebApplication
{
    public interface IWebApi
    {
        //[Get("/products")]
        [Get("/")]
        Task<List<Product>> GetAllProducts();

        [Get("/product/{id}")]
        Task<Product> GetProduct(int id);

        [Post("/addproduct")]
        Task<HttpResponseMessage> AddProduct([FromBody] Product productModel);

        [Delete("/deleteproduct")]
        Task<HttpResponseMessage> DeleteProduct(int id);

        [Put("/updateproduct")]
        Task<HttpResponseMessage> UpdateProduct([FromBody] Product productModel);
    }
}
