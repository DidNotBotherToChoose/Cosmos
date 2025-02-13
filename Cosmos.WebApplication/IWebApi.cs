using Cosmos.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace Cosmos.WebApplication
{
    public interface IWebApi
    {
        [Get("/getprodutos")]
        Task<List<ProdutoModel>> GetProdutos();

        [Get("/getproduto")]
        Task<ProdutoModel> GetProduto(int id);

        [Post("/addprodutos")]
        Task<HttpResponseMessage> AddProduto([FromBody] Cosmos.WebApi.Models.ProdutoModel produtoModel);

        [Delete("/deleteproduto")]
        Task<HttpResponseMessage> DeleteProduto(long id);

        [Put("/updateproduto")]
        Task<HttpResponseMessage> UpdateProduto([FromBody] ProdutoModel produtoModel);
    }
}
