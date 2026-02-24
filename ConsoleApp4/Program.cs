using ConsoleApp4.Armours.ConcreteArmours;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SnakeArmour snakeArmour = new SnakeArmour();
            Console.WriteLine(snakeArmour.ShieldIntegrity);


        }
    }
}

