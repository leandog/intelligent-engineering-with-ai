using Microsoft.EntityFrameworkCore;
using TaskManagementApi.Data;
using TaskManagementApi.Models;

namespace TaskManagementApi.Repositories
{
    public class TaskRepository(TaskContext context) : ITaskRepository
    {
        private readonly TaskContext context = context;

        public async Task<IEnumerable<TaskItem>> GetAllTasks()
        {
            return await context.TaskItems.ToListAsync();
        }

        public async Task<TaskItem> GetTaskById(int id)
        {
            var taskItem =
                await context.TaskItems.FindAsync(id) ?? throw new TaskNotFoundException(id);
            return taskItem;
        }

        public async Task<TaskItem> AddTask(TaskItem taskItem)
        {
            context.TaskItems.Add(taskItem);
            await context.SaveChangesAsync();
            return taskItem;
        }

        public async Task<TaskItem> UpdateTask(TaskItem taskItem)
        {
            context.Entry(taskItem).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return taskItem;
        }

        public async Task<bool> DeleteTask(int id)
        {
            var taskItem = await GetTaskById(id);
            context.TaskItems.Remove(taskItem);
            await context.SaveChangesAsync();
            return true;
        }
    }

    public class TaskNotFoundException(int taskId)
        : Exception($"Task with id {taskId} not found") { }
}
