using Microsoft.AspNetCore.Mvc;
using TaskManagementApi.Models;
using TaskManagementApi.Repositories;
using TaskManagementApi.Services;

namespace TaskManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskItemController(ITaskItemService taskService) : ControllerBase
    {
        private readonly ITaskItemService taskService = taskService;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskItem>>> GetAllTasks()
        {
            var taskItems = await taskService.GetAllTaskItems();
            return Ok(taskItems);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TaskItem>> GetTaskItemById(int id)
        {
            try
            {
                var task = await taskService.GetTaskItemById(id);
                return Ok(task);
            }
            catch (TaskItemNotFoundException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<TaskItem>> CreateTask(TaskItem task)
        {
            var createdTask = await taskService.AddTaskItem(task);
            return CreatedAtAction(
                nameof(GetTaskItemById),
                new { id = createdTask.Id },
                createdTask
            );
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTask(int id, TaskItem task)
        {
            if (id != task.Id)
            {
                return BadRequest();
            }
            var updatedTask = await taskService.UpdateTaskItem(task);
            if (updatedTask == null)
            {
                return NotFound();
            }
            return Ok(updatedTask);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            var isDeleted = await taskService.DeleteTaskItem(id);
            if (!isDeleted)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
