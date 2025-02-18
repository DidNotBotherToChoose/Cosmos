using CosmosLb.Cosmoslden;
using CosmosLb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cosmo.WebApi.Controllers
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


        [HttpGet("/getproducts")]

        public async Task<IActionResult> GetProducts()
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
            var product = await _cosmosContext.Products.FirstOrDefaultAsync(c => c.Id == model.Id);
            
            if (product is null) //se não existe, guarda novo produto
            {
                await _cosmosContext.Products.AddAsync(model);
            }
            else //se existe, atualiza produto
            {
                product.Id = model.Id;
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
            var product = await _cosmosContext.Products.FirstOrDefaultAsync(s => s.Id.Equals(id));

            if (product is null)
                return null;

            return product;
        }
    }
}

