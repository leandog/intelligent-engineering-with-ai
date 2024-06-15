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
        public async Task<ActionResult<IEnumerable<TaskItem>>> GetAllTaskItems()
        {
            var taskItems = await taskService.GetAllTaskItems();
            return Ok(taskItems);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TaskItem>> GetTaskItemById(int id)
        {
            try
            {
                var taskItem = await taskService.GetTaskItemById(id);
                return Ok(taskItem);
            }
            catch (TaskItemNotFoundException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<TaskItem>> CreateTaskItem(TaskItem taskItem)
        {
            var createdTaskItem = await taskService.AddTaskItem(taskItem);
            return CreatedAtAction(
                nameof(GetTaskItemById),
                new { id = createdTaskItem.Id },
                createdTaskItem
            );
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTask(int id, TaskItem taskItem)
        {
            if (id != taskItem.Id)
            {
                return BadRequest();
            }

            try
            {
                var updatedTaskItem = await taskService.UpdateTaskItem(taskItem);
                return Ok(taskItem);
            }
            catch (TaskItemNotFoundException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            try
            {
                await taskService.DeleteTaskItem(id);
                return NoContent();
            }
            catch (TaskItemNotFoundException e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
