using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Armours
{
    internal class SnakeArmour : Armour
    {
        public override void ArmourType()
        {
            Armours += 25;
        }
    }
}
