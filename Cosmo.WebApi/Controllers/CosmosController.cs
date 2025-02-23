using Cosmos.Shared.Data;
using Cosmos.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cosmos.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CosmosController : ControllerBase
    {
        protected readonly CosmosContext _cosmosContext;

        public CosmosController(CosmosContext cosmosContext)
        {
            _cosmosContext = cosmosContext;
        }

        [HttpGet("/products")]
        public async Task<List<Product>> GetAllProducts()
        {
            return await _cosmosContext.Products.ToListAsync();
        }

        [HttpPost("/saveproduct")]
        public async Task<IActionResult> SaveProduct(Product product)
        {
            await _cosmosContext.Products.AddAsync(product);

            var result= await _cosmosContext.SaveChangesAsync();

            if(result.Equals(1))
                return Ok();
            else
                return BadRequest(result);
        }

        [HttpPut("/updateproduct")]
        public async Task<IActionResult> UpdateProduct(Product product)
        {
            var productToUpdate = await _cosmosContext.Products.FirstOrDefaultAsync(p => p.ProductId.Equals(product.ProductId));

            if(productToUpdate is null)
                return BadRequest();

            productToUpdate.Name = product.Name;
            productToUpdate.Description = product.Description;
            productToUpdate.Price = product.Price;
            productToUpdate.Stock = product.Stock;
            productToUpdate.UpdatedAt = DateTime.Now;

            var result = await _cosmosContext.SaveChangesAsync();

            if (result.Equals(1))
                return Ok();
            else
                return BadRequest(result);
        }

        [HttpGetAttribute("/product/{id}")]
        public async Task<Product?> GetProduct(int id)
        {
            var product = await _cosmosContext.Products.FirstOrDefaultAsync(p => p.ProductId.Equals(id));
            if (product is null)
                return null;
            return product;
        }
    }
}
