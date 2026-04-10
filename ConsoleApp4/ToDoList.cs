namespace ConsoleApp4
{
    internal class ToDoList
    {

        public List<string> tasks = new List<string>();


        public void AddNotes()
        {
            Console.WriteLine("Please add your note. To confirm press double enter.");
            while(true)
            {
                string task = Console.ReadLine();
                if (task == "")
                {

                    break;
                }
                tasks.Add(task);
            }
            
        }

        public void RemoveNotes()
        {
            Console.WriteLine("Please write note which you want to erase");
            string removeItem = Console.ReadLine();
            bool eraser = tasks.Remove(removeItem);
            if (eraser)
            {
                Console.WriteLine($"Note {removeItem} was erased");
            }
            else
            {
                Console.WriteLine($"{removeItem} is not exists");
            }
        }

        public void ShowNotes()
        {
            int currentNumber = 1;
            foreach (string item in tasks)
            {
                Console.WriteLine($"{currentNumber}) {item}");
                currentNumber++;
            }
        }
        public void MarkNotes()
        {
            Console.WriteLine("Please write note which you want to mark");
            string markItem = Console.ReadLine();

            foreach (string item in tasks)
            {
                if (item == markItem)
                {
                    markItem = "✓" + markItem;
                }
            }
        }

        public void PrintText()
        {
            Console.WriteLine("                                                           Welcome                                                           ");
            Console.WriteLine("Input 1 to add new task");
            Console.WriteLine("Input 2 to remove task");
            Console.WriteLine("Input 3 to see your tasks");
            Console.WriteLine("Input 4 to mark tasks");
        }

    }
}
