using ConsoleApp4.Armours;
using ConsoleApp4.Armours.ConcreteArmours;

namespace ConsoleApp4
{
    public class Warrior : Character
    {
        public Armour Armour { get; set; }

        public override void TakeDamage(int damage)
        {
           if (Armour.ShieldIntegrity >= damage)
           {
                Armour.ShieldIntegrity -= damage;
           }
           else if (Armour.ShieldIntegrity < damage) 
           {
                Health = Health - (damage - Armour.ShieldIntegrity);
                Armour.ShieldIntegrity = 0;
           }
        }

        public void ArmourSet(Armour armour)
        {
            if (armour is DiamondArmour diamondArmour )
            {
                Armour.ShieldIntegrity += diamondArmour.ShieldIntegrity;
            }
            else if (armour is SnakeArmour snakeArmour)
            {
                Armour.ShieldIntegrity += snakeArmour.ShieldIntegrity;
            }
            else if (armour is MetalArmour metalArmour)
            {
                Armour.ShieldIntegrity += metalArmour.ShieldIntegrity;
            }
        }


        public override void Attack()
        {
            Console.WriteLine("Воин атакует!");
        }
    }
}
