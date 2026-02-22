namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Hero> heroAbility = new List<Hero>();
            heroAbility.Add(new Hero(50, 95, 60, true, true, true));
            heroAbility.Add(new Hero(65, 110, 75, true, true));
            heroAbility.Add(new Hero(500, 10, 20, true));

            foreach (var hero in heroAbility)
            {
                hero.HeroAbilitys();
                hero.TeleportCheck();
                hero.TelekinesCheck();
                hero.IsLegal();
            }
            Console.WriteLine("______________________________________________________");

            double x = 9;
            double y = 2;
            int value = -40;

            Console.WriteLine($"{Math.Sqrt(x)}");
            Console.WriteLine($"{Math.Pow(x, y)}");
            Console.WriteLine($"{Math.Abs(value)}");
        }

    }
}

