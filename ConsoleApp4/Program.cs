namespace ConsoleApp4
{
    public delegate void Math(int result);

    internal class Program
    {
        static void Main(string[] args)
        {
            Multiply(5, 7, Print);
            Sum(5, 7, Print);
        }

        public static void Multiply(int a, int b, Math math)
        {
            math.Invoke(a * b);
        }

        public static void Sum(int a, int b, Math math)
        {
            math.Invoke(a + b);
        }

        public static void Print(int result)
        {
            Console.WriteLine(result);
        }
    }

}
