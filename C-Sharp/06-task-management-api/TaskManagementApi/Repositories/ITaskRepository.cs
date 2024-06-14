using TaskManagementApi.Models;

namespace TaskManagementApi.Repositories
{
    public interface ITaskRepository
    {
        Task<IEnumerable<TaskItem>> GetAllTasks();
        Task<TaskItem> GetTaskById(int id);
        Task<TaskItem> AddTask(TaskItem task);
        Task<TaskItem> UpdateTask(TaskItem task);
        Task<bool> DeleteTask(int id);
    }
}
