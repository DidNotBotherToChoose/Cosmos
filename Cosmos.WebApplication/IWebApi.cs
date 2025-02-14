using Cosmos.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace Cosmos.WebApplication
{
    public interface IWebApi
    {
        [Get("/getprodutos")]
        Task<List<Product>> GetProdutos();

        //[Get("/getproduto")]
        //Task<ProdutoModel> GetProduto(int id);

        [Get("/produtos/{id}")]
        Task<Product> GetProduto(int id);

        [Post("/addprodutos")]
        Task<HttpResponseMessage> AddProduto([FromBody] Cosmos.WebApi.Models.ProdutoModel produtoModel);

        [Delete("/deleteproduto")]
        Task<HttpResponseMessage> DeleteProduto(long id);

        [Put("/updateproduto")]
        Task<HttpResponseMessage> UpdateProduto([FromBody] Product produtoModel);
    }
}
