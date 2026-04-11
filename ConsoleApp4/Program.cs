namespace ConsoleApp4
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            var todolist = new ToDoList();

            Console.WriteLine("Welcome");

            todolist.PrintText();

            while (true)
            {
                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    todolist.AddNotes();
                }
                else if (userInput == "2")
                {
                    todolist.RemoveNotes();
                }
                else if (userInput == "3")
                {
                    todolist.ShowNotes();
                }
                else if (userInput == "4")
                {
                    todolist.MarkNotes();
                }
                else
                {
                    Console.WriteLine("Wrong input please try again");
                }
            }
        }
    }
}
