using TaskManagementApi.Repositories;
using Task = TaskManagementApi.Models.Task;

namespace TaskManagementApi.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<IEnumerable<Task>> GetAllTasks()
        {
            return await _taskRepository.GetAllTasks();
        }

        public async Task<Task> GetTaskById(int id)
        {
            return await _taskRepository.GetTaskById(id);
        }

        public async Task<Task> AddTask(Task task)
        {
            return await _taskRepository.AddTask(task);
        }

        public async Task<Task> UpdateTask(Task task)
        {
            return await _taskRepository.UpdateTask(task);
        }

        public async Task<bool> DeleteTask(int id)
        {
            return await _taskRepository.DeleteTask(id);
        }
    }
}
