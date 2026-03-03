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
