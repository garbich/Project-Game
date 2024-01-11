namespace Myspace
{
    internal class Warrior : Hero
    {
        
        public Warrior(string Name, int Health, int AttackPower, int ResistanceToPhysical, int ResistanceToMagical) :
            base(Name, Health, AttackPower, ResistanceToPhysical, ResistanceToMagical)
        {
        }

        public int Attack(int AttackPower, Attack typeAttack, int strategy, int weather)
        {

            int totallDamage = AttackPower;

           
            if (CriticalChance() > 80)
            {
                Console.WriteLine("Warrior shield 100%");
                return 0;
            }

            if (strategy == 1) {
                totallDamage -= 3;
            }
            else
            {
                totallDamage += 3;
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
