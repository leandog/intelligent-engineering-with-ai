using Microsoft.EntityFrameworkCore;
using TaskManagementApi.Data;
using TaskManagementApi.Models;
using TaskManagementApi.Repositories;
using TaskStatus = TaskManagementApi.Models.TaskStatus;

namespace TaskManagementApiTests
{
    public class TaskRepositoryTests : IClassFixture<TaskContextFixture>
    {
        private readonly TaskContext context;
        private readonly TaskRepository repository;

        public TaskRepositoryTests(TaskContextFixture fixture)
        {
            context = fixture.Context;
            context.TaskItems.RemoveRange(context.TaskItems);
            context.SaveChanges();

            repository = new TaskRepository(context);
        }

        [Fact]
        public async Task AddTask_ShouldAddTask()
        {
            var taskItem = new TaskItem
            {
                Title = "Test Task",
                Description = "Test Description",
                DueDate = DateTime.Now,
                Status = TaskStatus.Pending
            };

            var result = await repository.AddTask(taskItem);

            Assert.NotNull(result);
            Assert.Equal(taskItem.Title, result.Title);
        }

        [Fact]
        public async Task GetAllTasks_ShouldReturnAllTasks()
        {
            context.TaskItems.AddRange(
                new List<TaskItem>
                {
                    new()
                    {
                        Title = "Task 1",
                        Description = "Description 1",
                        DueDate = DateTime.Now,
                        Status = TaskStatus.Pending
                    },
                    new()
                    {
                        Title = "Task 2",
                        Description = "Description 2",
                        DueDate = DateTime.Now,
                        Status = TaskStatus.InProgress
                    }
                }
            );
            await context.SaveChangesAsync();

            var result = await repository.GetAllTasks();

            Assert.Equal(2, result.Count());
        }

        [Fact]
        public async Task GetTaskById_ShouldReturnTask()
        {
            var taskItem = new TaskItem
            {
                Title = "Task 1",
                Description = "Description 1",
                DueDate = DateTime.Now,
                Status = TaskStatus.Pending
            };
            context.TaskItems.Add(taskItem);
            await context.SaveChangesAsync();

            var result = await repository.GetTaskById(taskItem.Id);

            Assert.NotNull(result);
            Assert.Equal(taskItem.Title, result.Title);
        }

        [Fact]
        public async Task UpdateTask_ShouldUpdateTask()
        {
            var taskItem = new TaskItem
            {
                Title = "Task 1",
                Description = "Description 1",
                DueDate = DateTime.Now,
                Status = TaskStatus.Pending
            };
            context.TaskItems.Add(taskItem);
            await context.SaveChangesAsync();

            taskItem.Title = "Updated Task";
            var result = await repository.UpdateTask(taskItem);

            Assert.NotNull(result);
            Assert.Equal("Updated Task", result.Title);
        }

        [Fact]
        public async Task DeleteTask_ShouldDeleteTask()
        {
            var taskItem = new TaskItem
            {
                Title = "Task 1",
                Description = "Description 1",
                DueDate = DateTime.Now,
                Status = TaskStatus.Pending
            };
            context.TaskItems.Add(taskItem);
            await context.SaveChangesAsync();

            var result = await repository.DeleteTask(taskItem.Id);

            Assert.True(result);
            await Assert.ThrowsAsync<TaskNotFoundException>(
                () => repository.GetTaskById(taskItem.Id)
            );
        }
    }
}
