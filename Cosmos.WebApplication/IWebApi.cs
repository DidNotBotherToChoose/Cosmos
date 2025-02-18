using Cosmos.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace Cosmos.WebApplication
{
    public interface IWebApi
    {
        [Get("/getproducts")]
        Task<List<Product>> GetProducts();

        //[Get("/getproduto")]
        //Task<ProdutoModel> GetProduto(int id);

        [Get("/products/{id}")]
        Task<Product> GetProduct(int id);

        [Post("/addproducts")]
        Task<HttpResponseMessage> AddProduct([FromBody] Cosmos.Shared.Models.Product productModel);

        [Delete("/deleteproduct")]
        Task<HttpResponseMessage> DeleteProduct(long id);

        [Put("/updateproduct")]
        Task<HttpResponseMessage> UpdateProduct([FromBody] Product productModel);
    }
}
