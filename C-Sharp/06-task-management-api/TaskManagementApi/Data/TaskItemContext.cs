using Microsoft.EntityFrameworkCore;
using TaskManagementApi.Models;

namespace TaskManagementApi.Data
{
    public class TaskItemContext(DbContextOptions<TaskItemContext> options) : DbContext(options)
    {
        public DbSet<TaskItem> TaskItems { get; set; }
    }
}
