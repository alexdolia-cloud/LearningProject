using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Warrior : Character
    {
        public int Armour { get; set; } = 100;

        public override void TakeDamage(int damage)
        {
           if (Armour >= damage)
           {
                Armour -= damage;
           }
           else if (Armour < damage) 
           {
                Health = Health - (damage - Armour);
                Armour = 0;
           }
        }

        public override void Attack()
        {
            Console.WriteLine("Воин атакует!");
        }
    }
}
