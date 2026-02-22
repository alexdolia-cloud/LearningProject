using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp4
{
    public class Archer : Character
    {
        public int Arrows { get; set; } = 6;
        
        public override void Attack()
        {
            if (Arrows > 0)
            {
                Console.WriteLine("Лучник атакует");
                Arrows--;
            }
            else if (Arrows <= 0)
            {
                Console.WriteLine("У лучника недостаточно стрел чтобы атаковать");
            }
        }
    }
}
