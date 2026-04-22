namespace ConsoleApp4
{
    internal class ToDoList
    {
        public List<ToDoItem> Tasks { get; private set; } = new List<ToDoItem>();
        public void AddNotes(string task)
        {
            Tasks.Add(new ToDoItem(task));
        }

        public void RemoveNotes(int removeItem)
        {

            if (Tasks.Count > 0)
            {
                Tasks.RemoveAt(removeItem - 1);
            }

        }

        public void ShowNotes(string mark)
        {
            int currentNumber = 1;

            if (Tasks.Count > 0) 
            {

                for (int i = 0; i < Tasks.Count; i++)
                {
                    if (Tasks[i].IsCompleted == true)
                    {
                        mark = "v";
                    }
                    Console.WriteLine($"{i + 1}) {Tasks[i].Title} {mark}");
                }

            }

        }
        public void MarkNotes(int markItemIndex)
        {
            Console.WriteLine("Please write note which you want to mark");
            if (Tasks[markItemIndex - 1].IsCompleted == false)
            {
                Tasks[markItemIndex - 1].IsCompleted = true;
                Console.WriteLine("Your note has been marked");
            }

            else
            {
                Tasks[markItemIndex - 1].IsCompleted = false;
                Console.WriteLine("Your note has been unmarked");
            }
        }
    }
}
