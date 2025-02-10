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


        [HttpGet("/gettasks")]

        public async Task<IActionResult> GetTasks()
        {
            var taskTable = await _cosmosContext.Produtos.ToListAsync();

            if (!taskTable.Any())
                return NotFound();
            else
                return Ok(taskTable);

        }
    }
}
}
