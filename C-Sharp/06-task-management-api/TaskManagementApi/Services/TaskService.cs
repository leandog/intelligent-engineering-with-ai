using TaskManagementApi.Models;
using TaskManagementApi.Repositories;

namespace TaskManagementApi.Services
{
    public class TaskService(ITaskRepository taskRepository) : ITaskService
    {
        private readonly ITaskRepository taskRepository = taskRepository;

        public async Task<IEnumerable<TaskItem>> GetAllTasks()
        {
            return await taskRepository.GetAllTasks();
        }

        public async Task<TaskItem> GetTaskById(int id)
        {
            return await taskRepository.GetTaskById(id);
        }

        public async Task<TaskItem> AddTask(TaskItem task)
        {
            return await taskRepository.AddTask(task);
        }

        public async Task<TaskItem> UpdateTask(TaskItem task)
        {
            return await taskRepository.UpdateTask(task);
        }

        public async Task<bool> DeleteTask(int id)
        {
            return await taskRepository.DeleteTask(id);
        }
    }
}
