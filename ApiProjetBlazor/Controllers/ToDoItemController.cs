using ApiProjetBlazor.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjetBlazor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoItemController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllToDoItems()
        {
            var toDoItems = new List<ToDoItem>
            {
                new ToDoItem
                {
                    Id = 1,
                    Title = "Menage",
                    Description = "Classer mes dossiers",
                    DueDate = "Aujourd'huit",
                    IsCompleted = false,

                }
            };
            return Ok(toDoItems);
        }
    }
}
