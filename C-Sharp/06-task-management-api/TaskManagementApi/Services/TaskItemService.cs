using TaskManagementApi.Models;
using TaskManagementApi.Repositories;

namespace TaskManagementApi.Services
{
    public class TaskItemService(ITaskItemRepository taskItemRepository) : ITaskItemService
    {
        private readonly ITaskItemRepository taskItemRepository = taskItemRepository;

        public async Task<IEnumerable<TaskItem>> GetAllTaskItems()
        {
            return await taskItemRepository.GetAllTaskItems();
        }

        public async Task<TaskItem> GetTaskItemById(int id)
        {
            return await taskItemRepository.GetTaskItemById(id);
        }

        public async Task<TaskItem> AddTaskItem(TaskItem task)
        {
            return await taskItemRepository.AddTaskItem(task);
        }

        public async Task<TaskItem> UpdateTaskItem(TaskItem task)
        {
            var taskItemToUpdate = await GetTaskItemById(task.Id);
            return await taskItemRepository.UpdateTaskItem(taskItemToUpdate);
        }

        public async Task<bool> DeleteTaskItem(int id)
        {
            return await taskItemRepository.DeleteTaskItem(id);
        }
    }
}
