using TaskManagementApi.Models;

namespace TaskManagementApi.Repositories
{
    public interface ITaskItemRepository
    {
        Task<IEnumerable<TaskItem>> GetAllTaskItems();
        Task<TaskItem> GetTaskItemById(int id);
        Task<TaskItem> AddTaskItem(TaskItem task);
        Task<TaskItem> UpdateTaskItem(TaskItem task);
        Task<bool> DeleteTaskItem(int id);
    }
}
