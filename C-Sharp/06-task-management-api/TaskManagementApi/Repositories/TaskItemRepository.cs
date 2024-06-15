using Microsoft.EntityFrameworkCore;
using TaskManagementApi.Data;
using TaskManagementApi.Models;

namespace TaskManagementApi.Repositories
{
    public class TaskItemRepository(TaskItemContext context) : ITaskItemRepository
    {
        private readonly TaskItemContext context = context;

        public async Task<IEnumerable<TaskItem>> GetAllTaskItems()
        {
            return await context.TaskItems.ToListAsync();
        }

        public async Task<TaskItem> GetTaskItemById(int id)
        {
            var taskItem =
                await context.TaskItems.FindAsync(id) ?? throw new TaskItemNotFoundException(id);
            return taskItem;
        }

        public async Task<TaskItem> AddTaskItem(TaskItem taskItem)
        {
            context.TaskItems.Add(taskItem);
            await context.SaveChangesAsync();
            return taskItem;
        }

        public async Task<TaskItem> UpdateTaskItem(TaskItem taskItem)
        {
            context.Entry(taskItem).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return taskItem;
        }

        public async Task<bool> DeleteTaskItem(int id)
        {
            var taskItem = await GetTaskItemById(id);
            context.TaskItems.Remove(taskItem);
            await context.SaveChangesAsync();
            return true;
        }
    }

    public class TaskItemNotFoundException(int taskId)
        : Exception($"Task Item with id {taskId} not found") { }
}
