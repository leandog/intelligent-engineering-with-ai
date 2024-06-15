using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using TaskManagementApi.Data;
using TaskManagementApi.Repositories;
using TaskManagementApi.Services;

namespace TaskManagementApi
{
    public class StartupTest(IConfiguration configuration)
    {
        public IConfiguration Configuration { get; } = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddScoped<ITaskItemRepository, TaskItemRepository>();
            services.AddScoped<ITaskItemService, TaskItemService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();

            // Apply migrations automatically during development
            using var scope = app.ApplicationServices.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<TaskItemContext>();
            dbContext.Database.Migrate();
            dbContext.TaskItems.RemoveRange(dbContext.TaskItems);
            dbContext.SaveChanges();

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
