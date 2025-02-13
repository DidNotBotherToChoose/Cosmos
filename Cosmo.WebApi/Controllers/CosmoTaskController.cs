using System.Runtime.InteropServices;
using CosmosLb.Cosmoslden;
using CosmosLb.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cosmo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CosmoTaskController : ControllerBase
    {
        private readonly CosmosContext _cosmosContext;
        public CosmoTaskController(CosmosContext cosmosContext)
        {
            _cosmosContext = cosmosContext;
        }


        [HttpGet("/getprodutos")]

        public async Task<IActionResult> GetTasks()
        {
            var taskTable = await _cosmosContext.Produtos.ToListAsync();

            if (!taskTable.Any())
                return NotFound();
            else
                return Ok(taskTable);

        }

        [HttpPost("/updateproduto")]
        public async Task<IActionResult> Update(Produto model)
        {
            var produto = await _cosmosContext.Produtos.FirstOrDefaultAsync(c => c.Id == model.Id);
            
            if (produto is null) //se não existe, guarda novo produto
            {
                await _cosmosContext.Produtos.AddAsync(model);
            }
            else //se existe, atualiza produto
            {
                produto.Id = model.Id;
                produto.Nome = model.Nome;
                produto.Descricao=model.Descricao;
                produto.Stock = model.Stock; 
            }

            var result = await _cosmosContext.SaveChangesAsync();

            if (result.Equals(1))
                return Ok();

            return BadRequest(result);
        }

        [HttpGet("/students/{id}")]
        public async Task<Produto> GetProduto(int id)
        {
            var produto = await _cosmosContext.Produtos.FirstOrDefaultAsync(s => s.Id.Equals(id));

            if (produto is null)
                return null;

            return produto;
        }
    }
}

