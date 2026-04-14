namespace ConsoleApp4
{
    internal class ToDoList
    {
        public List<ToDoItem> Tasks = new List<ToDoItem>();
        public void AddNotes()
        {
            Console.WriteLine("Please add your note");
            string task = Console.ReadLine();
            if (task == string.Empty)
            {
                PrintText();
            }
            Tasks.Add(new ToDoItem(task));
            Console.WriteLine("Your note has been added");
            PrintText();
        }

        public void RemoveNotes()
        {
            Console.WriteLine("Please write number of note which you want to erase");
            string removeItem = Console.ReadLine();
            if (int.TryParse(removeItem, out int userInput))
            {
                if (Tasks.Count == 0)
                {
                    Console.WriteLine("There is no notes to remove");
                }
                else
                {
                    Tasks.RemoveAt(userInput - 1);
                    Console.WriteLine("Your note was removed");
                }
            }
            PrintText();
        }

        public void ShowNotes()
        {
            int currentNumber = 1;
            string mark = "x";
            if (Tasks.Count == 0)
            {
                Console.WriteLine("You haven't add any notes yet");
            }
            else
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
            PrintText();
        }

        public void MarkNotes()
        {
            Console.WriteLine("Please write note which you want to mark");
            string userInput = Console.ReadLine();
            int.TryParse(userInput, out int markItem);
            Tasks[markItem - 1].IsCompleted = true;
            Console.WriteLine("Your note has been marked");
            PrintText();
        }

        public void UnMarkNotes()
        {
            Console.WriteLine("Please write note which you want to unmark");
            string userInput = Console.ReadLine();
            int.TryParse(userInput, out int markItem);
            Tasks[markItem - 1].IsCompleted = false;
            Console.WriteLine("Your note has been unmarked");
            PrintText();
        }

        public void PrintText()
        {
            Console.WriteLine("Input 1 to add new task");
            Console.WriteLine("Input 2 to remove task");
            Console.WriteLine("Input 3 to see your tasks");
            Console.WriteLine("Input 4 to mark tasks");
            Console.WriteLine("Inout 5 to unmark tasks");
            Console.WriteLine("Input 6 for tutorial");
        }

        public void Tutorial()
        {
            Console.WriteLine("If you input 1 you have to write task which will appear when you using (see tasks) ");
            Console.WriteLine("If you input 2 you could remove your task (you have to input 3 to see your task's number)");
            Console.WriteLine("If you input 3 you could see all your tasks and status. You can change status if you input 4");
            Console.WriteLine("If you input 4 you could mark any of your notes into v (completed) ");
            Console.WriteLine("if you input 5 you could unmark any of your notes into x (is not completed)");
            Console.WriteLine("If you input 6 you could see tutorial again");
        }
    }
}
