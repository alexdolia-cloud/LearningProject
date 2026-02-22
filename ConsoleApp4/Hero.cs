using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Hero
    {
        public int Speed { get; set; }

        public int flySpeed { get; set; }

        public int Power { get; set; }

        public bool CanTeleport { get; set; }

        public bool CanTelekines { get; set; }

        public bool Legal { get; set; }

        public Hero(int speed, int flySpeed, int power, bool canTeleport, bool canTelekines, bool legal)
        {
            Speed = speed;
            this.flySpeed = flySpeed;
            Power = power;
            CanTeleport = canTeleport;
            CanTelekines = canTelekines;
            Legal = legal;
        }
        public Hero(int speed, int flySpeed, int strong, bool canTeleport, bool canTelekines)
        {
            Speed = speed;
            this.flySpeed = flySpeed;
            Power = strong;
            CanTeleport = canTeleport;
            CanTelekines = canTelekines;
        }

        public Hero(int speed, int flySpeed, int strong, bool canTeleport)
        {
            Speed = speed;
            this.flySpeed = flySpeed;
            Power = strong;
            CanTeleport = canTeleport;
        }

        public void HeroAbilitys()
        {
            Console.Write($"Скорость ходьбы {Speed}км в час, ");

            Console.Write($"Скорость полета {flySpeed}км в час, ");

            Console.Write($"Сила {Power}, ");
        }

        public void TeleportCheck()
        {
            if (CanTeleport)
                Console.Write("У героя есть способность телепортации, ");
            else
                Console.Write("Герой не умеет телепортироваться, ");
        }

        public void TelekinesCheck()
        {
            if (CanTelekines)
                Console.Write("У героя телекинез, ");
            else
                Console.Write("У героя нету телекинеза,");
        }
            
            
        public void IsLegal()
        {
            if (Legal)
                Console.WriteLine($"Герой являеться легальным. ");
            else
                Console.WriteLine($"Герой не легальный.");
        }

        
    }
}

