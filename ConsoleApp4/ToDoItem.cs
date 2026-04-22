namespace ConsoleApp4
{
    internal class ToDoItem 
    {
        public string Title { get; set; }

        public bool IsCompleted { get; set; }

        public ToDoItem(string title)
        {
            Title = title;
        }
    }
}
