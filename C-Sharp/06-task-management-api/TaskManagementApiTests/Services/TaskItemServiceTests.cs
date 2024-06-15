using FluentAssertions;
using Moq;
using TaskManagementApi.Models;
using TaskManagementApi.Repositories;
using TaskManagementApi.Services;

namespace TaskManagementApi.Tests
{
    public class TaskItemServiceTests
    {
        private readonly Mock<ITaskItemRepository> mockRepository;
        private readonly TaskItemService service;

        public TaskItemServiceTests()
        {
            mockRepository = new Mock<ITaskItemRepository>();
            service = new TaskItemService(mockRepository.Object);
        }

        [Fact]
        public async Task GetAllTaskItems_ShouldReturnAllTaskItems()
        {
            var taskItems = new List<TaskItem>
            {
                new()
                {
                    Id = 1,
                    Title = "Task 1",
                    Description = "Description 1",
                    DueDate = DateTime.Now,
                    Status = TaskItemStatus.Pending
                },
                new()
                {
                    Id = 2,
                    Title = "Task 2",
                    Description = "Description 2",
                    DueDate = DateTime.Now,
                    Status = TaskItemStatus.InProgress
                }
            };
            mockRepository.Setup(repo => repo.GetAllTaskItems()).ReturnsAsync(taskItems);

            var result = await service.GetAllTaskItems();

            result.Should().BeEquivalentTo(taskItems);
        }

        [Fact]
        public async Task GetTaskItemById_ShouldReturnTask_WhenTaskItemExists()
        {
            var taskItem = new TaskItem
            {
                Id = 1,
                Title = "Task 1",
                Description = "Description 1",
                DueDate = DateTime.Now,
                Status = TaskItemStatus.Pending
            };
            mockRepository.Setup(repo => repo.GetTaskItemById(taskItem.Id)).ReturnsAsync(taskItem);

            var result = await service.GetTaskItemById(taskItem.Id);

            result.Should().BeEquivalentTo(taskItem);
        }

        [Fact]
        public async Task GetTaskItemById_ShouldReturnNull_WhenTaskDoesNotExist()
        {
            mockRepository
                .Setup(repo => repo.GetTaskItemById(It.IsAny<int>()))
                .ThrowsAsync(new TaskItemNotFoundException(1));

            await Assert.ThrowsAsync<TaskItemNotFoundException>(() => service.GetTaskItemById(1));
        }

        [Fact]
        public async Task AddTaskItem_ShouldAddTaskItem()
        {
            var taskItem = new TaskItem
            {
                Title = "New Task",
                Description = "New Description",
                DueDate = DateTime.Now,
                Status = TaskItemStatus.Pending
            };
            mockRepository.Setup(repo => repo.AddTaskItem(taskItem)).ReturnsAsync(taskItem);

            var result = await service.AddTaskItem(taskItem);

            result.Should().BeEquivalentTo(taskItem);
        }

        [Fact]
        public async Task UpdateTaskItem_ShouldUpdateTaskItem()
        {
            var taskItem = new TaskItem
            {
                Id = 1,
                Title = "Updated Task",
                Description = "Updated Description",
                DueDate = DateTime.Now,
                Status = TaskItemStatus.InProgress
            };
            mockRepository.Setup(repo => repo.GetTaskItemById(taskItem.Id)).ReturnsAsync(taskItem);
            mockRepository.Setup(repo => repo.UpdateTaskItem(taskItem)).ReturnsAsync(taskItem);

            var result = await service.UpdateTaskItem(taskItem);

            result.Should().BeEquivalentTo(taskItem);
        }

        [Fact]
        public async Task DeleteTaskItem_ShouldReturnTrue_WhenTaskItemIsDeleted()
        {
            var taskItemId = 1;
            mockRepository.Setup(repo => repo.DeleteTaskItem(taskItemId)).ReturnsAsync(true);

            var result = await service.DeleteTaskItem(taskItemId);

            result.Should().BeTrue();
        }
    }
}
