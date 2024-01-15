namespace Myspace
{
    internal class Archer : Hero
    {
        public Archer(string Name, int Health, double AttackPower, int ResistanceToPhysical, int ResistanceToMagical  ) :
            base(Name, Health, AttackPower, ResistanceToPhysical, ResistanceToMagical)
        {
        }

        public double Attack(double AttackPower, Attack typeAttack)
        {

            double totallDamage = AttackPower;

           

            if (CriticalChance() > 80)
            {
                Console.WriteLine("Archer shield 100%");
                Console.WriteLine("Attack end");
                return 0;
            }


            if (typeAttack == Myspace.Attack.Physical)
            {
                
                totallDamage -= ResistanceToPhysical;
                if (CriticalChance() > 50)
                {
                    Console.WriteLine("Enemy hit with critical damage");
                    totallDamage += 10;
                }
            }
            else
            {
               
                totallDamage -= ResistanceToMagical; 
                if (CriticalChance() > 50)
                {
                    Console.WriteLine("Enemy hit with critical damage");
                    totallDamage += 10;
                }
            }
            Console.WriteLine("Attack on archer end");

            return totallDamage;
        }
        public int CriticalChance()
        {
            Random random = new Random();
            int rand = random.Next(1, 100);
            return rand;
        }
    }
}
