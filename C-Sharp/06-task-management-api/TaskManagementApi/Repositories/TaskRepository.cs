using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TaskManagementApi.Data;
using TaskManagementApi.Models;
using Task = TaskManagementApi.Models.Task;

namespace TaskManagementApi.Repositories
{
    public class TaskRepository(TaskContext context) : ITaskRepository
    {
        private readonly TaskContext context = context;

        public async Task<IEnumerable<Task>> GetAllTasks()
        {
            return await context.Tasks.ToListAsync();
        }

        public async Task<Task> GetTaskById(int id)
        {
            var task = await context.Tasks.FindAsync(id) ?? throw new TaskNotFoundException(id);
            return task;
        }

        public async Task<Task> AddTask(Task task)
        {
            context.Tasks.Add(task);
            await context.SaveChangesAsync();
            return task;
        }

        public async Task<Task> UpdateTask(Task task)
        {
            context.Entry(task).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return task;
        }

        public async Task<bool> DeleteTask(int id)
        {
            var task = await context.Tasks.FindAsync(id);
            if (task == null)
            {
                return false;
            }

            context.Tasks.Remove(task);
            await context.SaveChangesAsync();
            return true;
        }
    }

    public class TaskNotFoundException(int taskId)
        : Exception($"Task with id {taskId} not found") { }
}
