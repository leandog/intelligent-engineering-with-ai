using Task = TaskManagementApi.Models.Task;

namespace TaskManagementApi.Services
{
    public interface ITaskService
    {
        Task<IEnumerable<Task>> GetAllTasks();
        Task<Task> GetTaskById(int id);
        Task<Task> AddTask(Task task);
        Task<Task> UpdateTask(Task task);
        Task<bool> DeleteTask(int id);
    }
}