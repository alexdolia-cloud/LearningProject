namespace ConsoleApp4
{
    internal class ToDoList
    {

        public List<string> Tasks = new List<string>();


        public void AddNotes()
        {
            Console.WriteLine("Please add your note");
            string task = Console.ReadLine();
            if (task == string.Empty)
            {
                PrintText();
            }
            Tasks.Add(task);
            Console.WriteLine("Your note has been added");
        }

        public void RemoveNotes()
        {
            Console.WriteLine("Please write number of note which you want to erase");
            string removeItem = Console.ReadLine();
            if (int.TryParse(removeItem, out int userInput))
            {
            
            }
            PrintText();
        }

        public void ShowNotes()
        {
            int currentNumber = 1;
            foreach (string item in Tasks)
            {
                Console.WriteLine($"{currentNumber}) {item}");
                currentNumber++;
                PrintText();
            }
        }
        public void MarkNotes()
        {
            Console.WriteLine("Please write note which you want to mark");
            string markItem = Console.ReadLine();
            for (int i = 0; i < Tasks.Count; i++)
            {
                if (Tasks[i] == markItem)
                {
                    Tasks[i] = "✓ " + Tasks[i];
                    break;
                }
            }
            PrintText();
        }

        public void PrintText()
        {
            Console.WriteLine("Input 1 to add new task");
            Console.WriteLine("Input 2 to remove task");
            Console.WriteLine("Input 3 to see your tasks");
            Console.WriteLine("Input 4 to mark tasks");
        }

    }
}
