using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskAPI.Controllers
{
    //Attributes
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet]//we have to include like this type of method before the method
        public IActionResult Tasks() //IActionResult: from this we can return OK from this type of method
        {
            var tasks = new String[] { "Task 1", "Task 2", "Task 3" };
            return Ok(tasks);
           
        }

        [HttpPost]
        public IActionResult NewTasks()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTasks()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteTasks()
        {
            var SomethingWentWrong = true;
            if (SomethingWentWrong)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
