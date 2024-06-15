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

        [Fact]
        public async Task CreateTask_ShouldAddTask()
        {
            var taskTitle = "Feed Grogu";
            var taskItem = await CreateTaskItem(taskTitle);

            taskItem.Should().NotBeNull();
            taskItem.Title.Should().Be(taskTitle);
        }

        [Fact]
        public async Task UpdateTask_ShouldUpdateTask()
        {
            var taskItem = await CreateTaskItem();
            taskItem.Title = "Updated Task";

            var putResponse = await client.PutAsJsonAsync(
                $"{ApiTaskItemRoute}/{taskItem.Id}",
                taskItem
            );
            putResponse.EnsureSuccessStatusCode();
            var updatedTask = (await putResponse.Content.ReadFromJsonAsync<TaskItem>())!;

            updatedTask.Should().NotBeNull();
            updatedTask.Title.Should().Be(taskItem.Title);
        }

        [Fact]
        public async Task UpdateTask_ShouldBeBadRequestWhenIdsDoNotMatch()
        {
            var taskItem = await CreateTaskItem();

            var putResponse = await client.PutAsJsonAsync($"{ApiTaskItemRoute}/0", taskItem);
            putResponse.StatusCode.Should().Be(System.Net.HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task UpdateTask_ShouldNotFoundWithInvalidTask()
        {
            var taskItem = new TaskItem
            {
                Id = 0,
                Title = "Invalid Task",
                Description = "Invalid Description",
                DueDate = DateTime.Now,
                Status = TaskItemStatus.Pending
            };

            var putResponse = await client.PutAsJsonAsync($"{ApiTaskItemRoute}/0", taskItem);
            putResponse.StatusCode.Should().Be(System.Net.HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task DeleteTask_ShouldDeleteTask()
        {
            var taskItem = await CreateTaskItem();

            var deleteResponse = await client.DeleteAsync($"{ApiTaskItemRoute}/{taskItem.Id}");
            deleteResponse.EnsureSuccessStatusCode();

            var getResponse = await client.GetAsync($"{ApiTaskItemRoute}/{taskItem.Id}");
            getResponse.StatusCode.Should().Be(System.Net.HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task DeleteTask_ShouldNotFoundWithInvalidTask()
        {
            var deleteResponse = await client.DeleteAsync($"{ApiTaskItemRoute}/0");
            deleteResponse.StatusCode.Should().Be(System.Net.HttpStatusCode.NotFound);
        }

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
