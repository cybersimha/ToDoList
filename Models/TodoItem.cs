namespace TodoList.Models // Make sure the namespace matches your project name
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }

        public DateTime DueDate { get; set; } // Added Due Date
        public string Priority { get; set; } // Added Priority
    }
}