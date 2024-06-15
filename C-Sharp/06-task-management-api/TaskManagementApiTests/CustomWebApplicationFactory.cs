using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TaskManagementApi.Data;
using TaskManagementApi.Models;

namespace TaskManagementApi.Tests
{
    public class CustomWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup>
        where TStartup : class
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                // Remove the existing DbContext registration
                var descriptor = services.SingleOrDefault(d =>
                    d.ServiceType == typeof(DbContextOptions<TaskItemContext>)
                );
                if (descriptor != null)
                {
                    services.Remove(descriptor);
                }

                // Add DbContext using an in-memory database for testing
                services.AddDbContext<TaskItemContext>(options =>
                {
                    options.UseInMemoryDatabase("InMemoryDbForTesting");
                });

                // Build the service provider
                var serviceProvider = new ServiceCollection()
                    .AddEntityFrameworkInMemoryDatabase()
                    .BuildServiceProvider();

                // Create a scope to obtain a reference to the database context
                using var scope = services.BuildServiceProvider().CreateScope();
                var scopedServices = scope.ServiceProvider;
                var db = scopedServices.GetRequiredService<TaskItemContext>();

                // Ensure the database is created
                db.Database.EnsureCreated();
                SeedTestData(db);
            });
        }

        private void SeedTestData(TaskItemContext context)
        {
            // Add test data to the in-memory database
            context.TaskItems.AddRange(
                new TaskItem
                {
                    Title = "Task 1",
                    Description = "Description 1",
                    DueDate = DateTime.Now,
                    Status = TaskItemStatus.Pending
                },
                new TaskItem
                {
                    Title = "Task 2",
                    Description = "Description 2",
                    DueDate = DateTime.Now,
                    Status = TaskItemStatus.InProgress
                }
            );

            context.SaveChanges();
        }
    }
}
