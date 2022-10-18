namespace BlazorApp
{
    public class TodoItem
    {
        public string? Title { get; set; }
        public DateOnly? DueDate { get; set; }
        public bool IsDone { get; set; }
    }
}
