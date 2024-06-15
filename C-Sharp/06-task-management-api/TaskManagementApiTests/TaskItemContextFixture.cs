using Microsoft.EntityFrameworkCore;
using TaskManagementApi.Data;

namespace TaskManagementApiTests
{
    public class TaskItemContextFixture : IDisposable
    {
        public TaskItemContext Context { get; private set; }

        public TaskItemContextFixture()
        {
            var options = new DbContextOptionsBuilder<TaskItemContext>()
                .UseInMemoryDatabase(databaseName: "TaskItemDatabase")
                .Options;
            Context = new TaskItemContext(options);
        }

        public void Dispose()
        {
            Context.Database.EnsureDeleted();
            Context.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}
