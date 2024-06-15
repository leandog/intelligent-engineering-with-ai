using Microsoft.EntityFrameworkCore;
using TaskManagementApi.Data;
using TaskManagementApi.Models;
using TaskManagementApi.Repositories;
using TaskItemStatus = TaskManagementApi.Models.TaskItemStatus;

namespace TaskManagementApiTests
{
    public class TaskItemRepositoryTests : IClassFixture<TaskItemContextFixture>
    {
        private readonly TaskItemContext context;
        private readonly TaskItemRepository repository;

        public TaskItemRepositoryTests(TaskItemContextFixture taskItemContextFixture)
        {
            context = taskItemContextFixture.Context;
            context.TaskItems.RemoveRange(context.TaskItems);
            context.SaveChanges();

            repository = new TaskItemRepository(context);
        }

        [Fact]
        public async Task AddTaskItem_ShouldAddTaskItem()
        {
            var taskItem = new TaskItem
            {
                Title = "Test Task",
                Description = "Test Description",
                DueDate = DateTime.Now,
                Status = TaskItemStatus.Pending
            };

            var result = await repository.AddTaskItem(taskItem);

            Assert.NotNull(result);
            Assert.Equal(taskItem.Title, result.Title);
        }

        [Fact]
        public async Task GetAllTaskItems_ShouldReturnAllTaskItems()
        {
            context.TaskItems.AddRange(
                new List<TaskItem>
                {
                    new()
                    {
                        Title = "Task 1",
                        Description = "Description 1",
                        DueDate = DateTime.Now,
                        Status = TaskItemStatus.Pending
                    },
                    new()
                    {
                        Title = "Task 2",
                        Description = "Description 2",
                        DueDate = DateTime.Now,
                        Status = TaskItemStatus.InProgress
                    }
                }
            );
            await context.SaveChangesAsync();

            var result = await repository.GetAllTaskItems();

            Assert.Equal(2, result.Count());
        }

        [Fact]
        public async Task GetTaskItemById_ShouldReturnTaskItem()
        {
            var taskItem = new TaskItem
            {
                Title = "Task 1",
                Description = "Description 1",
                DueDate = DateTime.Now,
                Status = TaskItemStatus.Pending
            };
            context.TaskItems.Add(taskItem);
            await context.SaveChangesAsync();

            var result = await repository.GetTaskItemById(taskItem.Id);

            Assert.NotNull(result);
            Assert.Equal(taskItem.Title, result.Title);
        }

        [Fact]
        public async Task UpdateTaskItem_ShouldUpdateTaskItem()
        {
            var taskItem = new TaskItem
            {
                Title = "Task 1",
                Description = "Description 1",
                DueDate = DateTime.Now,
                Status = TaskItemStatus.Pending
            };
            context.TaskItems.Add(taskItem);
            await context.SaveChangesAsync();

            taskItem.Title = "Updated Task";
            var result = await repository.UpdateTaskItem(taskItem);

            Assert.NotNull(result);
            Assert.Equal("Updated Task", result.Title);
        }

        [Fact]
        public async Task DeleteTaskItem_ShouldDeleteTaskItem()
        {
            var taskItem = new TaskItem
            {
                Title = "Task 1",
                Description = "Description 1",
                DueDate = DateTime.Now,
                Status = TaskItemStatus.Pending
            };
            context.TaskItems.Add(taskItem);
            await context.SaveChangesAsync();

            var result = await repository.DeleteTaskItem(taskItem.Id);

            Assert.True(result);
            await Assert.ThrowsAsync<TaskItemNotFoundException>(
                () => repository.GetTaskItemById(taskItem.Id)
            );
        }
    }
}
