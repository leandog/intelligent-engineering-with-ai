using Microsoft.AspNetCore.Mvc.Testing;

namespace TaskManagementApi.Tests
{
    public class TaskItemControllerStartupTest(WebApplicationFactory<Startup> factory)
        : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client = factory.CreateClient();

        [Fact]
        public async Task GetSwaggerEndpoint_ReturnsOk()
        {
            var response = await _client.GetAsync("/swagger/index.html");
            response.EnsureSuccessStatusCode();
        }
    }
}
