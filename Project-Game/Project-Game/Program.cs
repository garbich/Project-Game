
namespace Myspace
{
    enum Attack
    {
        Physical,
        Magical
    };

    class Program
    {
        private static double mage1Health = 85;
        private static double warrior1Health = 105;
        private static double archer1Health = 95;

        private static double mage1Attack = 25;
        private static double warrior1Attack = 30;
        private static double archer1Attack = 20;

        private static double mage2Health = 85;
        private static double warrior2Health = 105;
        private static double archer2Health = 95;

        private static double mage2Attack = 25;
        private static double warrior2Attack = 30;
        private static double archer2Attack = 20;

        private static double player1Damage = 0;
        private static double player2Damage = 0;

        private static int choose = 1;
        private static int choose2 = 1;
        private static int countinue = 0;
        private static int strategy = 1;

        private static int weather = 4;
        private static int location = 4;

        private static string start = "y";
        private static int round = 1;

        private static Warrior warrior1 = new Warrior("Warrior", warrior1Health, warrior1Attack, 10, 10);
        private static Mage mage1 = new Mage("Mage", mage1Health, mage1Attack, 5, 10);
        private static Archer archer1 = new Archer("Archer", archer1Health, archer1Attack, 10, 10);

        private static Warrior warrior2 = new Warrior("Warrior", warrior2Health, warrior2Attack, 10, 10);
        private static Mage mage2 = new Mage("Mage", mage2Health, mage2Attack, 5, 10);
        private static Archer archer2 = new Archer("Archer", archer2Health, archer2Attack, 10, 10);

        public static void Main(string[] args)
        {


            do
            {
                
                Console.WriteLine("Start round? - (y/n)");
                start = Console.ReadLine();
                if (start == "n")
                {
                    return;
                }

                Console.Write("Number of round: ");
                Console.Write(round);
                Console.WriteLine();
                

                chooseWeatherAndLocation();

                chooseHero();

                Console.WriteLine();

                mageBattles();
                warriorBattles();
                archerBattles();

                round++;
            } while (start != "n");

        }

        private static void chooseWeatherAndLocation()
        {

            Console.WriteLine("Choose location(1 - field, 2 - city, 3 - mountain, 4 - random)");
            location = Int32.Parse(Console.ReadLine());
            if (location == 1)
            {
                archer1Attack += 3;
                mage1Attack += 3;
                warrior1Attack -= 2;
            }
            else if (location == 2)
            {
                warrior1Attack += 2;
                mage1Attack -= 2;
                archer1Attack -= 2;
            }
            else if (location == 3)
            {
                warrior1Attack -= 3;
                mage1Attack += 3;
                archer1Attack += 2;
            }
            else if (location == 4)
            {
                Random random = new Random();
                location = random.Next(1, 3);
                Console.WriteLine(location);
            }
            else
            {
                Random random = new Random();
                location = random.Next(1, 3);
                Console.WriteLine(location);
            }

            Console.WriteLine("Choose weather(1 - rain, 2 - storm, 3 - snow, 4 - random)");
            weather = Int32.Parse(Console.ReadLine());
            if (weather == 1)
            {
                mage1Attack -= 3;
                warrior1Attack -= 2;
                archer1Attack -= 2;
                mage2Attack -= 3;
                warrior2Attack -= 2;
                archer2Attack -= 2;
            }
            else if (weather == 2)
            {
                mage1Attack += 5;
                archer1Attack -= 4;
            }
            else if (weather == 3)
            {
                warrior1Attack -= 3;
                archer1Attack += 2;
                mage1Attack -= 1;
            }
            else if (weather == 4)
            {
                Random random = new Random();
                weather = random.Next(1, 3);
                Console.WriteLine(weather);
            }
            else
            {
                Random random = new Random();
                weather = random.Next(1, 3);
                Console.WriteLine(weather);
            }
        }

        private static void chooseHero()
        {

            Console.WriteLine("Choose who attack(1 - Mage, 2 - Warrior, 3 - Archer)");
            choose = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Choose whom attack(1 - Mage, 2 - Warrior, 3 - Archer)");
            choose2 = Int32.Parse(Console.ReadLine());

            if (choose == 1)
            {

                Console.Write("Mage attacks ");
            }
            else if (choose == 2)
            {
                Console.Write("Warrior attacks ");
            }
            else if (choose == 3)
            {
                Console.Write("Archer attacks ");
            }

            if (choose2 == 1)
            {
                Console.WriteLine("mage");
            }
            else if (choose2 == 2)
            {
                Console.WriteLine("warrior");
            }
            else if (choose2 == 3)
            {
                Console.WriteLine("archer");
            }
            Console.WriteLine();
        }


        private static void mageBattles()
        {
            if (choose == 1 && choose2 == 2)
            {
                for (int i = 0; i < 99; i++)
                {
                    if (warrior1Health == 0 && mage1Health == 0)
                    {
                        Console.WriteLine("Draw");
                        break;
                    }
                    if (warrior1Health <= 0)
                    {
                        Console.WriteLine("Mage win");
                        break;
                    }
                    if (mage1Health <= 0)
                    {
                        Console.WriteLine("Warrior win");
                        break;
                    }
           
                    player1Damage = warrior1.Attack(mage1Attack, Attack.Magical);
                    Console.WriteLine($"Warrior health: {printHealth(warrior1Health, player1Damage)}");
                    warrior1Health = printHealth(warrior1Health, player1Damage);

                    player2Damage = mage1.Attack(warrior1Attack, Attack.Physical);
                    Console.WriteLine($"Mage health: {printHealth(mage1Health, player2Damage)}");
                    mage1Health = printHealth(mage1Health, player2Damage);

                    Console.WriteLine($"Player 1 damage: {player1Damage}" , Console.ForegroundColor = ConsoleColor.Green); Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine($"Player 2 damage: {player2Damage}");

                    Console.WriteLine();
                    Console.WriteLine();

                    countinue = Int32.Parse(Console.ReadLine());

                }
                warrior1Health = 105;
                mage1Health = 85;
                player1Damage = 0;
                player2Damage = 0;
            }
            else if (choose == 1 && choose2 == 3)
            {
                for (int i = 0; i < 99; i++)
                {
                    if (archer1Health == 0 && mage1Health == 0)
                    {
                        Console.WriteLine("Draw");
                        break;
                    }
                    if (archer1Health <= 0)
                    {
                        Console.WriteLine("Mage win");
                        break;
                    }
                    if (mage1Health <= 0)
                    {
                        Console.WriteLine("Archer win");
                        break;
                    }
                    player1Damage = archer1.Attack(mage1Attack, Attack.Magical);
                    Console.WriteLine($"Archer health: {printHealth(archer1Health, player1Damage)}");
                    archer1Health = printHealth(archer1Health, player1Damage);

                    player2Damage = mage1.Attack(archer1Attack, Attack.Physical);
                    Console.WriteLine($"Mage health: {printHealth(mage1Health, player2Damage)}");
                    mage1Health = printHealth(mage1Health, player2Damage);

                    Console.WriteLine($"Player 1 damage: {player1Damage}");
                    Console.WriteLine($"Player 2 damage: {player2Damage}");



                    Console.WriteLine();
                    Console.WriteLine();
                }
                archer1Health = 95;
                mage1Health = 85;
                player1Damage = 0;
                player2Damage = 0;
            }
            else if (choose == 1 && choose2 == 1)
            {

                for (int i = 0; i < 99; i++)
                {
                    if (mage1Health == 0 && mage2Health == 0)
                    {
                        Console.WriteLine("Draw");
                        break;
                    }
                    if (mage2Health <= 0)
                    {
                        Console.WriteLine("Mage 1 win");
                        break;
                    }
                    if (mage1Health <= 0)
                    {
                        Console.WriteLine("Mage 2 win");
                        break;
                    }
                    player1Damage = mage2.Attack(mage1Attack, Attack.Magical);
                    Console.WriteLine($"Mage 2 health: {printHealth(mage2Health, player1Damage)}");
                    mage2Health = printHealth(mage2Health, player1Damage);

                    player2Damage = mage1.Attack(mage2Attack, Attack.Magical);
                    Console.WriteLine($"Mage 1 health: {printHealth(mage1Health, player2Damage)}");
                    mage1Health = printHealth(mage1Health, player2Damage);

                    Console.WriteLine($"Player 1 damage: {player1Damage}");
                    Console.WriteLine($"Player 2 damage: {player2Damage}");



                    Console.WriteLine();
                    Console.WriteLine();

                }
                mage1Health = 85;
                mage2Health = 85;
                player1Damage = 0;
                player2Damage = 0;
            }
        }

        private static void warriorBattles()
        {
            if (choose == 2 && choose2 == 1)
            {
                for (int i = 0; i < 99; i++)
                {
                    if (warrior1Health == 0 && mage1Health == 0)
                    {
                        Console.WriteLine("Draw");
                        break;
                    }
                    if (mage1Health <= 0)
                    {
                        Console.WriteLine("Warrior win");
                        break;
                    }
                    if (warrior1Health <= 0)
                    {
                        Console.WriteLine("Mage win");
                        break;
                    }
                    player1Damage = mage1.Attack(warrior1Attack, Attack.Physical);
                    Console.WriteLine($"Mage health: {printHealth(mage1Health, player1Damage)}");
                    mage1Health = printHealth(mage1Health, player1Damage);

                    player2Damage = warrior1.Attack(mage1Attack, Attack.Magical);
                    Console.WriteLine($"Warrior health: {printHealth(warrior1Health, player2Damage)}");
                    warrior1Health = printHealth(warrior1Health, player2Damage);

                    Console.WriteLine($"Player 1 damage: {player1Damage}");
                    Console.WriteLine($"Player 2 damage: {player2Damage}");



                    Console.WriteLine();
                    Console.WriteLine();
                }
                warrior1Health = 105;
                mage1Health = 85;
                player1Damage = 0;
                player2Damage = 0;
            }
            else if (choose == 2 && choose2 == 3)
            {
                for (int i = 0; i < 99; i++)
                {
                    if (warrior1Health == 0 && archer1Health == 0)
                    {
                        Console.WriteLine("Draw");
                        break;
                    }
                    if (archer1Health <= 0)
                    {
                        Console.WriteLine("Warrior win");
                        break;
                    }
                    if (warrior1Health <= 0)
                    {
                        Console.WriteLine("Archer win");
                        break;
                    }
                    player1Damage = archer1.Attack(warrior1Attack, Attack.Physical);
                    Console.WriteLine($"Archer health: {printHealth(archer1Health, player1Damage)}");
                    archer1Health = printHealth(archer1Health, player1Damage);

                    player2Damage = warrior1.Attack(archer1Attack, Attack.Physical);
                    Console.WriteLine($"Warrior health: {printHealth(warrior1Health, player2Damage)}");
                    warrior1Health = printHealth(warrior1Health, player2Damage);

                    Console.WriteLine($"Player 1 damage: {player1Damage}");
                    Console.WriteLine($"Player 2 damage: {player2Damage}");



                    Console.WriteLine();
                    Console.WriteLine();
                }
                archer1Health = 95;
                warrior1Health = 105;
                player1Damage = 0;
                player2Damage = 0;
            }
            else if (choose == 2 && choose2 == 2)
            {
                for (int i = 0; i < 99; i++)
                {
                    if (warrior1Health == 0 && warrior2Health == 0)
                    {
                        Console.WriteLine("Draw");
                        break;
                    }
                    if (warrior1Health <= 0)
                    {
                        Console.WriteLine("Warrior 2 win");
                        break;
                    }
                    if (warrior2Health <= 0)
                    {
                        Console.WriteLine("Warrior 1 win");
                        break;
                    }
                    player1Damage = warrior2.Attack(warrior1Attack, Attack.Physical);
                    Console.WriteLine($"Warrior 2 health: {printHealth(warrior2Health, player1Damage)}");
                    warrior2Health = printHealth(warrior2Health, player1Damage);

                    player2Damage = warrior1.Attack(warrior2Attack, Attack.Physical);
                    Console.WriteLine($"Warrior 1 health: {printHealth(warrior1Health, player2Damage)}");
                    warrior1Health = printHealth(warrior1Health, player2Damage);

                    Console.WriteLine($"Player 1 damage: {player1Damage}");
                    Console.WriteLine($"Player 2 damage: {player2Damage}");



                    Console.WriteLine();
                    Console.WriteLine();

                }
                warrior1Health = 105;
                warrior2Health = 105;
                player1Damage = 0;
                player2Damage = 0;
            }
        }

        private static void archerBattles()
        {
            if (choose == 3 && choose2 == 1)
            {
                for (int i = 0; i < 99; i++)
                {
                    if (archer1Health == 0 && mage1Health == 0)
                    {
                        Console.WriteLine("Draw");
                        break;
                    }
                    if (mage1Health <= 0)
                    {
                        Console.WriteLine("Archer win");
                        break;
                    }
                    else if (archer1Health <= 0)
                    {
                        Console.WriteLine("Mage win");
                        break;
                    }
                    player1Damage = mage1.Attack(archer1Attack, Attack.Physical);
                    Console.WriteLine($"Mage health: {printHealth(mage1Health, player1Damage)}");
                    mage1Health = printHealth(mage1Health, player1Damage);

                    player2Damage = archer1.Attack(mage1Attack, Attack.Magical);
                    Console.WriteLine($"Archer health: {printHealth(archer1Health, player2Damage)}");
                    archer1Health = printHealth(archer1Health, player2Damage);

                    Console.WriteLine($"Player 1 damage: {player1Damage}");
                    Console.WriteLine($"Player 2 damage: {player2Damage}");



                    Console.WriteLine();

                }
                archer1Health = 95;
                mage1Health = 85;
                player1Damage = 0;
                player2Damage = 0;
            }

            else if (choose == 3 && choose2 == 2)
            {
                for (int i = 0; i < 99; i++)
                {
                    if (warrior1Health == 0 && archer1Health == 0)
                    {
                        Console.WriteLine("Draw");
                        break;
                    }
                    if (warrior1Health <= 0)
                    {
                        Console.WriteLine("Archer win");
                        break;
                    }
                    else if (archer1Health <= 0)
                    {
                        Console.WriteLine("Warrior win");
                        break;
                    }
                    player1Damage = warrior1.Attack(archer1Attack, Attack.Physical);
                    Console.WriteLine($"Warrior health: {printHealth(warrior1Health, player1Damage)}");
                    warrior1Health = printHealth(warrior1Health, player1Damage);

                    player2Damage = archer1.Attack(warrior1Attack, Attack.Physical);
                    Console.WriteLine($"Archer health: {printHealth(archer1Health, player2Damage)}");
                    archer1Health = printHealth(archer1Health, player2Damage);

                    Console.WriteLine($"Player 1 damage: {player1Damage}");
                    Console.WriteLine($"Player 2 damage: {player2Damage}");



                    Console.WriteLine();
                }
                archer1Health = 95;
                warrior1Health = 105;
                player1Damage = 0;
                player2Damage = 0;
            }

            else if (choose == 3 && choose2 == 3)
            {
                for (int i = 0; i < 99; i++)
                {
                    if (archer1Health == 0 && archer2Health == 0)
                    {
                        Console.WriteLine("Draw");
                        break;
                    }
                    if (archer1Health <= 0)
                    {
                        Console.WriteLine("Archer 2 win");
                        break;
                    }
                    if (archer2Health <= 0)
                    {
                        Console.WriteLine("Archer 1 win");
                        break;
                    }
                    player1Damage = archer2.Attack(archer1Attack, Attack.Physical);
                    Console.WriteLine($"Archer 2 health: {printHealth(archer2Health, player1Damage)}");
                    archer2Health = printHealth(archer2Health, player1Damage);

                    player2Damage = archer1.Attack(archer2Attack, Attack.Physical);
                    Console.WriteLine($"Archer 1 health: {printHealth(archer1Health, player2Damage)}");
                    archer1Health = printHealth(archer1Health, player2Damage);


                    Console.WriteLine();
                }
                archer1Health = 95;
                archer2Health = 95;
                player1Damage = 0;
                player2Damage = 0;
            }
        }

        private static double printHealth(double health, double damage)
        {
            health -= damage;

            if (health < 0)
            {
                return 0;
            }
            return health;
        }

        private static void strategyOnRound()
        {
            if(strategy == 1)
            {

            }
            else
            {

            }
        }

        //private static void shop()
        //{
        //    int choice = 0;
        //    Console.WriteLine("Make a choice: ");
        //    Console.WriteLine("1 - Attack Power(+10)");
        //    Console.WriteLine("2 - Health(+15)");
        //    Console.WriteLine("3 - ResistanceToPhysical(+8)");
        //    Console.WriteLine("4 - ResistanceToMagical(+6)");

        //    switch (choice)
        //    {
        //        case 1:
        //            mage1Attack += 10;
                   
        //        break;
        //        case 2:

        //        break;

        //        case 3:

        //        break;
        //        case 4:

        //        break;

        //    }
        //}
    }
}