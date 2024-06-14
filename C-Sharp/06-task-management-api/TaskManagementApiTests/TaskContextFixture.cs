using Microsoft.EntityFrameworkCore;
using TaskManagementApi.Data;

namespace TaskManagementApiTests
{
    public class TaskContextFixture : IDisposable
    {
        public TaskContext Context { get; private set; }

        public TaskContextFixture()
        {
            var options = new DbContextOptionsBuilder<TaskContext>()
                .UseInMemoryDatabase(databaseName: "TaskDatabase")
                .Options;
            Context = new TaskContext(options);
        }

        public void Dispose()
        {
            Context.Database.EnsureDeleted();
            Context.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}
