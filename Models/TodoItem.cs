namespace TodoList.Models // Make sure the namespace matches your project name
{
            public enum TodoStatus // Enum for Status field
            {
                InProgress,
                Completed,
                Abandoned
            }
    public class TodoItem
    {


        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }

        public DateTime DueDate { get; set; } // Added Due Date
        public string Priority { get; set; } // Added Priority

        public TodoStatus Status { get; set; } // Added Status field

        public string Comments { get; set; } // Added Comments field
    }
}