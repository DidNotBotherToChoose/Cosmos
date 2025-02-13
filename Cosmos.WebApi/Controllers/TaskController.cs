using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Azure.Core;
using Cosmos.Data;
using Microsoft.EntityFrameworkCore;
using Cosmos.WebApi.Models;
using Cosmos.CosmosIden;

namespace Cosmos.WebApi.Controllers
   
{
    [Route("api/[Controller]")]
    [ApiController]

    public class TaskController : Controller
    {
        private readonly CosmosContext _cosmosContext;
        public TaskController(CosmosContext cosmosContext)
        {
            _cosmosContext = cosmosContext;
        }


        [HttpGet("/getprodutos")]

        public async Task<IActionResult> GetProdutos()
        {
            var taskTable = await _cosmosContext.Produtos.Where(t=>t.IsDeleted ==false).ToListAsync();

            if (!taskTable.Any())
                return NotFound();
            else 
                return Ok(taskTable);
        }

        [HttpGet("/getproduto")]

        public async Task<IActionResult> GetProduto(int id)
        {
            var taskTable = await _cosmosContext.Produtos.FirstOrDefaultAsync(t => t.IsDeleted == false&& t.Id.Equals(id));

            if (taskTable is null)
                return NotFound();
            else
                return Ok(taskTable);
        }

        [HttpPost("/addprodutos")]
        public async Task<IActionResult> AddProduto(ProdutoModel produtoModel)
        {
            var produto = await _cosmosContext.Produtos.FirstOrDefaultAsync(t => t.Id.Equals(produtoModel.Id));

            if (produto is not null) 
                return BadRequest();

            var newProduto = new Produto();
            newProduto.Nome = produtoModel.Nome;
            newProduto.Descricao = produtoModel.Descricao;
            newProduto.CreatedAt = DateTime.Now;
            newProduto.UpdatedAt = DateTime.Now;

            _cosmosContext.Produtos.Add(newProduto);

            var result = await _cosmosContext.SaveChangesAsync();

            if (result.Equals(1))
                return Ok();
            
            return BadRequest();
        }

        [HttpDelete("/deleteproduto")]
        public async Task<IActionResult> DeleteProduto(long id)
        {
            var produto = await _cosmosContext.Produtos.FirstOrDefaultAsync(t => t.Id.Equals(id));

            if (produto is null)
                return BadRequest();

            produto.IsDeleted = true;

            var result = await _cosmosContext.SaveChangesAsync();

            if (result.Equals(1))
                return Ok();

            return BadRequest();
        }

        [HttpPut("/updateproduto")]
        public async Task<IActionResult> UpdateProduto(ProdutoModel produtoModel)
        {
            var produto = await _cosmosContext.Produtos.FirstOrDefaultAsync(t => t.Id.Equals(produtoModel.Id));

            if (produto is null)
                return BadRequest();

            produto.Nome = produtoModel.Nome;
            produto.Descricao = produtoModel.Descricao;
            produto.UpdatedAt = DateTime.Now;

            var result=await _cosmosContext.SaveChangesAsync();

            if (result.Equals(1))
                return Ok();

            return BadRequest();
        }
    }
}
