using Microsoft.AspNetCore.Mvc;
using TaskManagementApi.Models;
using TaskManagementApi.Services;

namespace TaskManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController(ITaskService taskService) : ControllerBase
    {
        private readonly ITaskService taskService = taskService;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskItem>>> GetAllTasks()
        {
            var tasks = await taskService.GetAllTasks();
            return Ok(tasks);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TaskItem>> GetTaskById(int id)
        {
            var task = await taskService.GetTaskById(id);
            if (task == null)
            {
                return NotFound();
            }
            return Ok(task);
        }

        [HttpPost]
        public async Task<ActionResult<TaskItem>> CreateTask(TaskItem task)
        {
            var createdTask = await taskService.AddTask(task);
            return CreatedAtAction(nameof(GetTaskById), new { id = createdTask.Id }, createdTask);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTask(int id, TaskItem task)
        {
            if (id != task.Id)
            {
                return BadRequest();
            }
            var updatedTask = await taskService.UpdateTask(task);
            if (updatedTask == null)
            {
                return NotFound();
            }
            return Ok(updatedTask);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            var isDeleted = await taskService.DeleteTask(id);
            if (!isDeleted)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
