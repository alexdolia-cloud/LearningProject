using System.ComponentModel.Design;

namespace ConsoleApp4
{
    internal class ToDoList
    {
        public List<ToDoItem> Tasks = new List<ToDoItem>();
        public void AddNotes(string task)
        {
            Tasks.Add(new ToDoItem(task));
        }

        public void RemoveNotes(string removeItem)
        {
            if (int.TryParse(removeItem, out int userInput))
            {
                if (Tasks.Count > 0)
                {
                    Tasks.RemoveAt(userInput - 1);
                }
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

        public void MarkNotes(string userInput, bool check)
        {
            Console.WriteLine("Please write note which you want to mark");
            int.TryParse(userInput, out int markItem);
            if (Tasks[markItem - 1].IsCompleted == false)
            {
                Tasks[markItem - 1].IsCompleted = true;
                check = true;
            }
            else
            {
                Tasks[markItem - 1].IsCompleted = false;
                check = true;
            }
        }
    }
}
