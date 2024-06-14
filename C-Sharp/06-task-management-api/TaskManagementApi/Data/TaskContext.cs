using Microsoft.EntityFrameworkCore;
using TaskManagementApi.Models;

namespace TaskManagementApi.Data
{
    public class TaskContext(DbContextOptions<TaskContext> options) : DbContext(options)
    {
        public DbSet<TaskItem> TaskItems { get; set; }
    }
}
