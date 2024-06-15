using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using TaskManagementApi.Data;
using TaskManagementApi.Repositories;
using TaskManagementApi.Services;

namespace TaskManagementApi
{
    public class Startup(IConfiguration configuration)
    {
        public IConfiguration Configuration { get; } = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<TaskItemContext>(options =>
                options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"))
            );
            services.AddScoped<ITaskItemRepository, TaskItemRepository>();
            services.AddScoped<ITaskItemService, TaskItemService>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TaskManagementApi", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "TaskManagementApi v1")
                );

                // Apply migrations automatically during development
                using var scope = app.ApplicationServices.CreateScope();
                var dbContext = scope.ServiceProvider.GetRequiredService<TaskItemContext>();
                dbContext.Database.Migrate();
            }

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
