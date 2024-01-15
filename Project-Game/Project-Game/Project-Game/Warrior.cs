namespace Myspace
{
    internal class Warrior : Hero
    {
        
        public Warrior(string Name, int Health, double AttackPower, int ResistanceToPhysical, int ResistanceToMagical) :
            base(Name, Health, AttackPower, ResistanceToPhysical, ResistanceToMagical)
        {
        }

        public double Attack(double AttackPower, Attack typeAttack)
        {

            double totallDamage = AttackPower;

           
            if (CriticalChance() > 80)
            {
                Console.WriteLine("Warrior shield 100%");
                Console.WriteLine("Attack end");
                return 0;
            }

           

            if (typeAttack == Myspace.Attack.Physical)
            {
               
                totallDamage -= ResistanceToPhysical;
                if (CriticalChance() > 50)
                {
                    Console.WriteLine("Enemy hit with critical damage");
                    totallDamage += 5;
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
            Console.WriteLine("Attack on warrior end");

            return totallDamage;
        }

       
        private int CriticalChance()
        {
            Random random = new Random();
            int rand = random.Next(1, 100);
            return rand;
        }
    }
}
