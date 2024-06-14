using Microsoft.EntityFrameworkCore;
using Task = TaskManagementApi.Models.Task;

namespace TaskManagementApi.Data
{
    public class TaskContext(DbContextOptions<TaskContext> options) : DbContext(options)
    {
        public DbSet<Task> Tasks { get; set; }
    }
}
