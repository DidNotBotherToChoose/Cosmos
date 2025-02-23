
using Cosmos.Shared.Data;
using Cosmos.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Cosmos.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CosmosTaskController : ControllerBase
    {
        private readonly CosmosContext _cosmosContext;
        public CosmosTaskController(CosmosContext cosmosContext)
        {
            _cosmosContext = cosmosContext;
        }


        [HttpGet("/products")]

        public async Task<IActionResult> GetAllProducts()
        {
            var product = await _cosmosContext.Products.ToListAsync();

            if (!product.Any())
                return NotFound();
            else
                return Ok(product);

        }

        [HttpPost("/updateproduct")]
        public async Task<IActionResult> UpdateProduct(Product model)
        {
            var product = await _cosmosContext.Products.FirstOrDefaultAsync(c => c.ProductId == model.ProductId);
            
            if (product is null) //se não existe, guarda novo produto
            {
                await _cosmosContext.Products.AddAsync(model);
            }
            else //se existe, atualiza produto
            {
                product.ProductId = model.ProductId;
                product.Name = model.Name;
                product.Description = model.Description;
                product.Stock = model.Stock; 
            }

            var result = await _cosmosContext.SaveChangesAsync();

            if (result.Equals(1))
                return Ok();

            return BadRequest(result);
        }

        [HttpGet("/products/{id}")]
        public async Task<Product> GetProduct(int id)
        {
            var product = await _cosmosContext.Products.FirstOrDefaultAsync(s => s.ProductId.Equals(id));

            if (product is null)
                return null;

            return product;
        }
    }
}

