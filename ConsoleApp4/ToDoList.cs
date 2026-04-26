namespace ConsoleApp4
{
    internal class ToDoList
    {
        public List<ToDoItem> Tasks { get; private set; } = new List<ToDoItem>();
        public void AddNotes(string task)
        {
            Tasks.Add(new ToDoItem(task));
        }

        public void RemoveNotes(int removeItemIndex)
        {
            if (Tasks.Contains(Tasks[removeItemIndex - 1]))
            {
                Tasks.RemoveAt(removeItemIndex - 1);
            }

        }

        public void ShowNotes(string status)
        {
            int currentNumber = 1;

            if (Tasks.Count > 0) 
            {
                for (int i = 0; i < Tasks.Count; i++)
                {
                    if (Tasks[i].IsCompleted == true)
                    {
                        status = "| completed";
                    }
                    else if (Tasks[i].IsCompleted == false)
                    {
                        status = " | isnt completed";
                    }
                        Console.WriteLine($"{i + 1}) {Tasks[i].Title} {status}");
                }
            }
        }

        public bool MarkNotes(int markItemIndex)
        {
            if (Tasks[markItemIndex - 1].IsCompleted == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsNoteExists(int chekedIndex)
        {
            if (chekedIndex < Tasks.Count && chekedIndex > 0)
            {
                return true;
            }
            else return false;
        }
    }
}
