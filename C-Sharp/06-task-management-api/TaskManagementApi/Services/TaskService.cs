using TaskManagementApi.Repositories;
using Task = TaskManagementApi.Models.Task;

namespace TaskManagementApi.Services
{
    public class TaskService(ITaskRepository taskRepository) : ITaskService
    {
        private readonly ITaskRepository taskRepository = taskRepository;

        public async Task<IEnumerable<Task>> GetAllTasks()
        {
            return await taskRepository.GetAllTasks();
        }

        public async Task<Task> GetTaskById(int id)
        {
            return await taskRepository.GetTaskById(id);
        }

        public async Task<Task> AddTask(Task task)
        {
            return await taskRepository.AddTask(task);
        }

        public async Task<Task> UpdateTask(Task task)
        {
            return await taskRepository.UpdateTask(task);
        }

        public async Task<bool> DeleteTask(int id)
        {
            return await taskRepository.DeleteTask(id);
        }
    }
}
