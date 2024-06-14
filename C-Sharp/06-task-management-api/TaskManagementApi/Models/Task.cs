namespace TaskManagementApi.Models
{
    public enum TaskStatus
    {
        Pending,
        InProgress,
        Completed
    }

    public class TaskItem
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required DateTime DueDate { get; set; }
        public required TaskStatus Status { get; set; }
    }
}
