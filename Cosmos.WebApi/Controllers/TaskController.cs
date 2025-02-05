using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Azure.Core;
using Cosmos.Data;
using Microsoft.EntityFrameworkCore;

namespace Cosmos.WebApi.Controllers
   
{
    [Route("/api[Controller]")]
    [ApiController]

    public class TaskController : Controller
    {
        private readonly CosmosContext _cosmosContext;
        public TaskController(CosmosContext cosmosContext)
        {
            _cosmosContext = cosmosContext;
        }


        [HttpGet("/gettasks")]

        public async Task<IActionResult> GetTasks()
        {
            var taskTable = await _cosmosContext.Produtos.ToListAsync();

            return Ok(taskTable);
        }
    }
}
