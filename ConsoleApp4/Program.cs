namespace ConsoleApp4
{
    delegate void Action<in T>(T n1, T n2);

    delegate T Func<in R, out T>(R r, R r2);

    delegate bool Predicate<in T>(T obj);

    internal class Program
    {
        // Action, Func, Predicate
        // Generics (!)

        static void Main(string[] args)
        {
            //var list = new List<int>()
            //{
            //    1, 2, 3, 4, 5, 6, 7, 8, 9
            //};

            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i] >= 4)
            //        Console.WriteLine(list[i]);
            //}

            //foreach (var item in list)
            //{
            //    if (item >= 4)
            //        Console.WriteLine(item);
            //}

            //list.Where(el => el >= 4).ToList().ForEach(Console.WriteLine);

            var x = DoOperation(3, 3, Multiply);

            Console.WriteLine(x);
        }

        public static int DoOperation(int a, int b, Func<int, int, int> action)
        {
            return action.Invoke(a, b);
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static bool IsPositiveValue(int x, Predicate<int> predicate) => predicate(x);
    }
}
