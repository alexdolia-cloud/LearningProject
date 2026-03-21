namespace ConsoleApp4
{
    public delegate void AccountHandler(string message);

    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new Account(100);

            account.Put(20);
            Console.WriteLine($"Current state of account: {account.Sum}");
            account.Take(70);
            Console.WriteLine($"Current state of account: {account.Sum}");
            account.Take(180);
            Console.WriteLine($"Current state of account: {account.Sum}");
        }
    }

    class Account
    {
        public event AccountHandler PutNotify;
        public event AccountHandler TakeNotify;

        public int Sum { get; private set; }

        public Account(int sum)
        {
            IninializeNotifyEvent();

            Sum = sum;
        }

        private void IninializeNotifyEvent()
        {
            PutNotify += PrintPutNotify;
            TakeNotify += PrintTakeNotify;
        }

        public void Put(int sum)
        {
            Sum += sum;
            PutNotify?.Invoke($"The following amount was credited to the account: {sum}");
        }

        public void Take(int sum)
        {
            if (Sum >= sum)
                Sum -= sum;

            TakeNotify?.Invoke($"Take {sum}");
        }

        public void PrintPutNotify(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void PrintTakeNotify(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
