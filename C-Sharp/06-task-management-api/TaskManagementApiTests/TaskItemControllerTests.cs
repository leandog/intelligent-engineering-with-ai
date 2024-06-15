using System.Net.Http.Json;
using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using TaskManagementApi.Models;

namespace TaskManagementApi.Tests
{
    public class TestServerFixture
    {
        public HttpClient Client { get; }

        public TestServerFixture()
        {
            var factory = new WebApplicationFactory<StartupTest>();
            Client = factory
                .WithWebHostBuilder(builder =>
                {
                    builder.UseStartup<StartupTest>();
                })
                .CreateClient();
        }
    }

    public class TaskItemControllerTests(TestServerFixture fixture)
        : IClassFixture<TestServerFixture>
    {
        private readonly HttpClient client = fixture.Client;
        private readonly string ApiTaskItemRoute = "/api/TaskItem";

        [Fact]
        public async Task GetAllTasks_ShouldReturnAllTasks()
        {
            var taskItem = await CreateTaskItem();

            var response = await client.GetAsync(ApiTaskItemRoute);
            response.EnsureSuccessStatusCode();
            var taskItems = (await response.Content.ReadFromJsonAsync<List<TaskItem>>())!;

            taskItems.Should().NotBeNull();
            taskItems.Should().Contain(t => t.Id == taskItem.Id);
        }

        [Fact]
        public async Task GetTaskById_ShouldReturnTask_WhenTaskExists()
        {
            var taskItem = await CreateTaskItem();

            var response = await client.GetAsync($"{ApiTaskItemRoute}/{taskItem.Id}");
            response.EnsureSuccessStatusCode();
            var fetchedTask = (await response.Content.ReadFromJsonAsync<TaskItem>())!;

            fetchedTask.Should().NotBeNull();
            fetchedTask.Title.Should().Be(fetchedTask.Title);
        }

        [Fact]
        public async Task GetTaskById_ShouldReturnNotFound_WhenTaskDoesNotExist()
        {
            var response = await client.GetAsync($"{ApiTaskItemRoute}/99999");

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.NotFound);
        }

        // [Fact]
        // public async Task CreateTask_ShouldAddTask()
        // {
        //     // Arrange
        //     var task = new Task
        //     {
        //         Title = "New Task",
        //         Description = "New Description",
        //         DueDate = DateTime.Now,
        //         Status = TaskStatus.Pending
        //     };

        //     // Act
        //     var response = await _client.PostAsJsonAsync("/api/tasks", task);
        //     response.EnsureSuccessStatusCode();
        //     var createdTask = await response.Content.ReadFromJsonAsync<Task>();

        //     // Assert
        //     createdTask.Should().NotBeNull();
        //     createdTask.Title.Should().Be(task.Title);
        // }

        // [Fact]
        // public async Task UpdateTask_ShouldUpdateTask()
        // {
        //     // Arrange
        //     var task = new Task
        //     {
        //         Title = "Initial Task",
        //         Description = "Initial Description",
        //         DueDate = DateTime.Now,
        //         Status = TaskStatus.Pending
        //     };
        //     var postResponse = await _client.PostAsJsonAsync("/api/tasks", task);
        //     postResponse.EnsureSuccessStatusCode();
        //     var createdTask = await postResponse.Content.ReadFromJsonAsync<Task>();

        //     createdTask.Title = "Updated Task";

        //     // Act
        //     var putResponse = await _client.PutAsJsonAsync(
        //         $"/api/tasks/{createdTask.Id}",
        //         createdTask
        //     );
        //     putResponse.EnsureSuccessStatusCode();
        //     var updatedTask = await putResponse.Content.ReadFromJsonAsync<Task>();

        //     // Assert
        //     updatedTask.Should().NotBeNull();
        //     updatedTask.Title.Should().Be("Updated Task");
        // }

        // [Fact]
        // public async Task DeleteTask_ShouldDeleteTask()
        // {
        //     // Arrange
        //     var task = new Task
        //     {
        //         Title = "Task to be deleted",
        //         Description = "To be deleted",
        //         DueDate = DateTime.Now,
        //         Status = TaskStatus.Pending
        //     };
        //     var postResponse = await _client.PostAsJsonAsync("/api/tasks", task);
        //     postResponse.EnsureSuccessStatusCode();
        //     var createdTask = await postResponse.Content.ReadFromJsonAsync<Task>();

        //     // Act
        //     var deleteResponse = await _client.DeleteAsync($"/api/tasks/{createdTask.Id}");
        //     deleteResponse.EnsureSuccessStatusCode();

        //     // Assert
        //     var getResponse = await _client.GetAsync($"/api/tasks/{createdTask.Id}");
        //     getResponse.StatusCode.Should().Be(System.Net.HttpStatusCode.NotFound);
        // }
        private async Task<TaskItem> CreateTaskItem(
            string title = "Test Task",
            string description = "Test Description",
            DateTime? dueDate = null,
            TaskItemStatus status = TaskItemStatus.Pending
        )
        {
            var taskItem = new TaskItem
            {
                Title = title,
                Description = description,
                DueDate = dueDate ?? DateTime.Now,
                Status = status
            };

            var postResponse = await client.PostAsJsonAsync("/api/TaskItem", taskItem);
            postResponse.EnsureSuccessStatusCode();
            return (await postResponse.Content.ReadFromJsonAsync<TaskItem>())!;
        }
    }
}
