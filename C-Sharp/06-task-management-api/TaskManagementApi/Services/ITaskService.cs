using TaskManagementApi.Models;

namespace TaskManagementApi.Services
{
    public interface ITaskService
    {
        Task<IEnumerable<TaskItem>> GetAllTasks();
        Task<TaskItem> GetTaskById(int id);
        Task<TaskItem> AddTask(TaskItem task);
        Task<TaskItem> UpdateTask(TaskItem task);
        Task<bool> DeleteTask(int id);
    }
}
