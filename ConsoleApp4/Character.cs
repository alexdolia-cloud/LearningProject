using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Character
    { 
        public string Name { get; set; }
        public int Level { get; set; } = 1;
        public int Health { get; set; } = 100;

        public int Damage { get; set; }

        public virtual void TakeDamage(int damage)
        {
            Health -= damage;
        }

        public void Heal(int amount)
        {
            Health += amount;
        }
        public virtual void Attack()
        {
            Console.WriteLine("Персонаж атакует!");
        }

    }
}
