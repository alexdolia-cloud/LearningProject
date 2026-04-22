namespace ConsoleApp4
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            var todolist = new ToDoList();

            Console.WriteLine("Welcome");

            PrintText();

            while (true)
            {
                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    Console.WriteLine("Please add your note");
                    string userTask = Console.ReadLine();

                    todolist.AddNotes(userTask);

                    Console.WriteLine("Your note has been added");
                    PrintText();
                }
                else if (userInput == "2")
                {
                    Console.WriteLine("Please write number of note which you want to erase");
                    int.TryParse(Console.ReadLine(), out int removeItem);
                    if (todolist.Tasks.Any())
                    {
                        Console.WriteLine("Your note was removed");
                        todolist.RemoveNotes(removeItem);
                    }
                    else
                    {
                        Console.WriteLine("There is no notes to remove");
                    }

                }
                else if (userInput == "3")
                {
                    if (todolist.Tasks.Any())
                    {
                        string mark = "x";
                        todolist.ShowNotes(mark);
                    }
                    else
                    {
                        Console.WriteLine("You haven't add any notes yet");
                    }
                }
                else if (userInput == "4")
                {
                    int.TryParse(Console.ReadLine(), out int markInputIndex);

                    if (todolist.Tasks.Any())
                    {
                        Console.WriteLine("Input number of note to mark it");
                        todolist.MarkNotes(markInputIndex);
                    }
                    else
                    {
                        Console.WriteLine("You didnt add any notes yet");
                    }
                    PrintText();


                }
                else if (userInput == "5")
                {
                    Tutorial();
                }
                else if (userInput == "6")
                {
                    Console.WriteLine("Program is end");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input please try again");
                }
            }
        }
        public static void PrintText()
        {
            Console.WriteLine("Input 1 to add new task");
            Console.WriteLine("Input 2 to remove task");
            Console.WriteLine("Input 3 to see your tasks");
            Console.WriteLine("Input 4 to mark tasks");
            Console.WriteLine("Input 5 for tutorial");
            Console.WriteLine("Input 6 to end program");
        }

        public static void Tutorial()
        {
            Console.WriteLine("If you input 1 you have to write task which will appear when you using (see tasks) ");
            Console.WriteLine("If you input 2 you could remove your task (you have to input 3 to see your task's number)");
            Console.WriteLine("If you input 3 you could see all your tasks and status. You can change status if you input 4");
            Console.WriteLine("If you input 4 you could mark or unmark any of your notes into v (completed) ");
            Console.WriteLine("If you input 5 you could see tutorial again");
        }
    }
}
