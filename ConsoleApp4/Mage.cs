using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Mage : Character
    {
        public int Mana { get; set; } = 100;
        public override void Attack()
        {
            if (Mana > 0)
            {
                Console.WriteLine("Маг атакует!");
                Mana -= 10;
            }
            else if (Mana <= 0)
            {
                Console.WriteLine("У мага недостаточно маны для атаки");
            }
        }
    }
}
