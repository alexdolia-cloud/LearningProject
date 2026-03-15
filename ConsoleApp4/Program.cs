namespace ConsoleApp4
{
    internal class Program
    {
        // Generic types (!!)
        // Func & Actions (!!!)
        // Delegase => Events (!!!)
        // IComparer (...)

        public delegate void Print(string message);

        static void Main(string[] args)
        {
            MultiplyAndPrint(3, 9, PrintMessage);
        }

        public static void MultiplyAndPrint(int x, int y, Print print)
        {
            print.Invoke((x * y).ToString());
        }

        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

}
