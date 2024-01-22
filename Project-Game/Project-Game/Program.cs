namespace Myspace
{
    enum Attack
    {
        Physical,
        Magical
    };

    class Program
    {
        private static double mage1Health = 720;
        private static double warrior1Health = 1150;
        private static double archer1Health = 1000;

        private static double mage1Attack = 281;
        private static double warrior1Attack = 202;
        private static double archer1Attack = 225;

        private static double mage2Health = 720;
        private static double warrior2Health = 1150;
        private static double archer2Health = 1000;

        private static double mage2Attack = 291;
        private static double warrior2Attack = 202;
        private static double archer2Attack = 225;

        private static double player1Damage = 0;
        private static double player2Damage = 0;

        private static int choose = 1;
        private static int choose2 = 1;
        private static string countinue = "";
        private static int strategy = 1;

        private static int weather = 4;
        private static int location = 4;

        private static string start = "y";
        private static int round = 1;

        private static Warrior warrior1 = new Warrior("Warrior", warrior1Health, warrior1Attack, 37, 30);
        private static Mage mage1 = new Mage("Mage", mage1Health, mage1Attack, 20, 25);
        private static Archer archer1 = new Archer("Archer", archer1Health, archer1Attack, 23, 25);

        private static Warrior warrior2 = new Warrior("Warrior", warrior2Health, warrior2Attack, 37, 30);
        private static Mage mage2 = new Mage("Mage", mage2Health, mage2Attack, 20, 25);
        private static Archer archer2 = new Archer("Archer", archer2Health, archer2Attack, 23, 25);

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

                Console.Write("Number of round: ", Console.ForegroundColor = ConsoleColor.Magenta);
                Console.Write(round);
                whiteBackGround();
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
                archer1Attack += 30;
                mage1Attack += 25;
                warrior1Attack -= 20;

                archer2Attack += 30;
                mage2Attack += 25;
                warrior2Attack -= 20;
            }
            else if (location == 2)
            {
                warrior1Attack += 20;
                mage1Attack -= 15;
                archer1Attack -= 18;

                warrior2Attack += 20;
                mage2Attack -= 15;
                archer2Attack -= 18;
            }
            else if (location == 3)
            {
                warrior1Attack -= 28;
                mage1Attack += 25;
                archer1Attack += 20;

                warrior2Attack -= 28;
                mage2Attack += 25;
                archer2Attack += 20;
            }
            else if (location == 4)
            {
                Random random = new Random();
                location = random.Next(1, 4);
                Console.WriteLine("Choosed location - " + location);
            }
            else
            {
                Random random = new Random();
                location = random.Next(1, 4);
                Console.WriteLine("Choosed location - " + location);
            }

            Console.WriteLine("Choose weather(1 - rain, 2 - storm, 3 - snow, 4 - random)");
            weather = Int32.Parse(Console.ReadLine());
            if (weather == 1)
            {
                mage1Attack -= 26;
                warrior1Attack -= 27;
                archer1Attack -= 25;

                mage2Attack -= 26;
                warrior2Attack -= 27;
                archer2Attack -= 25;
            }
            else if (weather == 2)
            {
                mage1Attack += 40;
                archer1Attack -= 30;

                mage1Attack += 40;
                archer1Attack -=30 ;
            }
            else if (weather == 3)
            {
                warrior1Attack -= 25;
                archer1Attack += 30;
                mage1Attack -= 10;

                warrior1Attack -= 25;
                archer1Attack += 30;
                mage1Attack -= 10;
            }
            else if (weather == 4)
            {
                Random random = new Random();
                weather = random.Next(1, 4);
                Console.WriteLine("Choosed weather - " + weather);
            }
            else
            {
                Random random = new Random();
                weather = random.Next(1, 4);
                Console.WriteLine("Choosed weather - " + weather);
            }
        }

        private static void chooseHero()
        {

            Console.WriteLine("Choose who attack(1 - Mage, 2 - Warrior, 3 - Archer, 4 - Random)");
            choose = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Choose whom attack(1 - Mage, 2 - Warrior, 3 - Archer, 4 - Random)");
            choose2 = Int32.Parse(Console.ReadLine());

            if (choose == 4)
            {
                Random random = new Random();
                choose = random.Next(1, 4);

            }
            if (choose2 == 4)
            {
                Random random = new Random();
                choose2 = random.Next(1, 4);

            }

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
                    player1Damage = warrior1.Attack(mage1Attack, Attack.Magical);
                    Console.WriteLine($"Player 1 damage: {player1Damage}", redBackGround());
                    Console.WriteLine($"Warrior health: {printHealth(warrior1Health, player1Damage)}", greenBackGround()); 
                    whiteBackGround();
                    warrior1Health = printHealth(warrior1Health, player1Damage);
                    if (warriorLose(warrior1Health)) { break; }
                    countinue = Console.ReadLine();

                    player2Damage = mage1.Attack(warrior1Attack, Attack.Physical);
                    Console.WriteLine($"Player 2 damage: {player2Damage}", redBackGround());
                    Console.WriteLine($"Mage health: {printHealth(mage1Health, player2Damage)}", greenBackGround()); 
                    whiteBackGround();
                    mage1Health = printHealth(mage1Health, player2Damage);
                    if (mageLose(mage1Health)) { break; }

                    Console.WriteLine();
                    countinue = Console.ReadLine();

                }
                reset();
            }
            else if (choose == 1 && choose2 == 3)
            {
                for (int i = 0; i < 99; i++)
                { 
                    player1Damage = archer1.Attack(mage1Attack, Attack.Magical);
                    Console.WriteLine($"Player 1 damage: {player1Damage}", redBackGround());
                    Console.WriteLine($"Archer health: {printHealth(archer1Health, player1Damage)}",greenBackGround());
                    whiteBackGround();
                    archer1Health = printHealth(archer1Health, player1Damage);
                    if (archerLose(archer1Health)) { break; }
                    countinue = Console.ReadLine();
                    player2Damage = mage1.Attack(archer1Attack, Attack.Physical);
                    Console.WriteLine($"Player 2 damage: {player2Damage}", redBackGround());
                    Console.WriteLine($"Mage health: {printHealth(mage1Health, player2Damage)}", greenBackGround());
                    whiteBackGround();
                    mage1Health = printHealth(mage1Health, player2Damage);
                    if (mageLose(mage1Health)) { break; }

                    Console.WriteLine();
                    Console.WriteLine();
                    countinue = Console.ReadLine();
                }
                reset();
            }
            else if (choose == 1 && choose2 == 1)
            {

                for (int i = 0; i < 99; i++)
                {

                    player1Damage = mage2.Attack(mage1Attack, Attack.Magical);
                    Console.WriteLine($"Player 1 damage: {player1Damage}", redBackGround());
                    Console.WriteLine($"Mage 2 health: {printHealth(mage2Health, player1Damage)}", greenBackGround());
                    whiteBackGround();
                    mage2Health = printHealth(mage2Health, player1Damage);
                    if (mageLose(mage1Health)) { break; }
                    countinue = Console.ReadLine();
                    player2Damage = mage1.Attack(mage2Attack, Attack.Magical);
                    Console.WriteLine($"Player 2 damage: {player2Damage}", redBackGround());
                    Console.WriteLine($"Mage 1 health: {printHealth(mage1Health, player2Damage)}", greenBackGround());
                    whiteBackGround();
                    mage1Health = printHealth(mage1Health, player2Damage);
                    if (mageLose(mage1Health)) { break; }

                    Console.WriteLine();
                    Console.WriteLine();
                    countinue = Console.ReadLine();

                }
                reset();
            }
        }

        private static void warriorBattles()
        {
            if (choose == 2 && choose2 == 1)
            {
                for (int i = 0; i < 99; i++)
                {

                    player1Damage = mage1.Attack(warrior1Attack, Attack.Physical);
                    Console.WriteLine($"Player 1 damage: {player1Damage}", redBackGround());
                    Console.WriteLine($"Mage health: {printHealth(mage1Health, player1Damage)}", greenBackGround());
                    whiteBackGround();
                    mage1Health = printHealth(mage1Health, player1Damage);
                    if (mageLose(mage1Health)) { break; }
                    countinue = Console.ReadLine();
                    player2Damage = warrior1.Attack(mage1Attack, Attack.Magical);
                    Console.WriteLine($"Player 2 damage: {player2Damage}", redBackGround());
                    Console.WriteLine($"Warrior health: {printHealth(warrior1Health, player2Damage)}", greenBackGround());
                    whiteBackGround();
                    warrior1Health = printHealth(warrior1Health, player2Damage);
                    if (warriorLose(warrior1Health)) { break; }
                   
                    Console.WriteLine();
                    
                    countinue = Console.ReadLine();
                }
                reset();
            }
            else if (choose == 2 && choose2 == 3)
            {
                for (int i = 0; i < 99; i++)
                {

                    player1Damage = archer1.Attack(warrior1Attack, Attack.Physical);
                    Console.WriteLine($"Player 1 damage: {player1Damage}", redBackGround());
                    Console.WriteLine($"Archer health: {printHealth(archer1Health, player1Damage)}", greenBackGround());
                    archer1Health = printHealth(archer1Health, player1Damage);
                    if (archerLose(archer1Health)) { break; }
                    countinue = Console.ReadLine();
                    player2Damage = warrior1.Attack(archer1Attack, Attack.Physical);
                    Console.WriteLine($"Player 2 damage: {player2Damage}", redBackGround());
                    Console.WriteLine($"Warrior health: {printHealth(warrior1Health, player2Damage)}", greenBackGround());
                    whiteBackGround();
                    warrior1Health = printHealth(warrior1Health, player2Damage);
                    if (warriorLose(warrior1Health)) { break; }

                    Console.WriteLine();
                    countinue = Console.ReadLine();
                }
                reset();
            }
            else if (choose == 2 && choose2 == 2)
            {
                for (int i = 0; i < 99; i++)
                {

                    player1Damage = warrior2.Attack(warrior1Attack, Attack.Physical);
                    Console.WriteLine($"Player 1 damage: {player1Damage}", redBackGround());
                    Console.WriteLine($"Warrior 2 health: {printHealth(warrior2Health, player1Damage)}", greenBackGround());
                    whiteBackGround();
                    warrior2Health = printHealth(warrior2Health, player1Damage);
                    if (warriorLose(warrior1Health)) { break; }
                    countinue = Console.ReadLine();
                    player2Damage = warrior1.Attack(warrior2Attack, Attack.Physical);
                    Console.WriteLine($"Player 2 damage: {player2Damage}", redBackGround());
                    Console.WriteLine($"Warrior 1 health: {printHealth(warrior1Health, player2Damage)}", greenBackGround());
                    whiteBackGround();
                    warrior1Health = printHealth(warrior1Health, player2Damage);
                    if (warriorLose(warrior1Health)) { break; }

                    Console.WriteLine();
                    countinue = Console.ReadLine();

                }
                reset();
            }
        }

        private static void archerBattles()
        {
            if (choose == 3 && choose2 == 1)
            {
                for (int i = 0; i < 99; i++)
                {

                    player1Damage = mage1.Attack(archer1Attack, Attack.Physical);
                    Console.WriteLine($"Player 1 damage: {player1Damage}", redBackGround());
                    Console.WriteLine($"Mage health: {printHealth(mage1Health, player1Damage)}", greenBackGround());
                    whiteBackGround();
                    mage1Health = printHealth(mage1Health, player1Damage);
                    if (mageLose(mage1Health)) { break; }
                    countinue = Console.ReadLine();
                    player2Damage = archer1.Attack(mage1Attack, Attack.Magical);
                    Console.WriteLine($"Player 2 damage: {player2Damage}", redBackGround());
                    Console.WriteLine($"Archer health: {printHealth(archer1Health, player2Damage)}", greenBackGround());
                    whiteBackGround();
                    archer1Health = printHealth(archer1Health, player2Damage);
                    if (archerLose(archer1Health)) { break; }
                 
                    Console.WriteLine();
                    countinue = Console.ReadLine();

                }
                reset();
            }

            else if (choose == 3 && choose2 == 2)
            {
                for (int i = 0; i < 99; i++)
                {

                    player1Damage = warrior1.Attack(archer1Attack, Attack.Physical);
                    Console.WriteLine($"Player 1 damage: {player1Damage}", redBackGround());
                    Console.WriteLine($"Warrior health: {printHealth(warrior1Health, player1Damage)}", greenBackGround());
                    whiteBackGround();
                    warrior1Health = printHealth(warrior1Health, player1Damage);
                    if (warriorLose(warrior1Health)) { break; }
                    countinue = Console.ReadLine();
                    player2Damage = archer1.Attack(warrior1Attack, Attack.Physical);
                    Console.WriteLine($"Player 2 damage: {player2Damage}", redBackGround());
                    Console.WriteLine($"Archer health: {printHealth(archer1Health, player2Damage)}", greenBackGround());
                    whiteBackGround();
                    archer1Health = printHealth(archer1Health, player2Damage);
                    if (archerLose(archer1Health)) { break; }

                    Console.WriteLine();
                    countinue = Console.ReadLine();
                }
                reset();
            }

            else if (choose == 3 && choose2 == 3)
            {
                for (int i = 0; i < 99; i++)
                {

                    player1Damage = archer2.Attack(archer1Attack, Attack.Physical);
                    Console.WriteLine($"Player 1 damage: {player1Damage}", redBackGround());
                    Console.WriteLine($"Archer 2 health: {printHealth(archer2Health, player1Damage)}", greenBackGround());
                    whiteBackGround();
                    archer2Health = printHealth(archer2Health, player1Damage);
                    if (archerLose(archer1Health)) { break; }
                    countinue = Console.ReadLine();
                    player2Damage = archer1.Attack(archer2Attack, Attack.Physical);
                    Console.WriteLine($"Player 2 damage: {player2Damage}", redBackGround());
                    Console.WriteLine($"Archer 1 health: {printHealth(archer1Health, player2Damage)}", greenBackGround());
                    whiteBackGround();
                    archer1Health = printHealth(archer1Health, player2Damage);
                    if (archerLose(archer1Health)) { break; }

                    Console.WriteLine();
                    countinue = Console.ReadLine();
                }
                reset();
            }
        }

        private static double printHealth(double health, double damage)
        {
            health -= damage;

            if (health <= 0)
            {
                return 0;
            }
            return health;
        }

        private static bool mageLose(double health)
        {
            if (health == 0)
            {
                Console.WriteLine("Mage lose!");
                return true;
            }
            return false;
        }

        private static bool warriorLose(double health)
        {
            if (health == 0)
            {
                Console.WriteLine("Warrior lose!");
                return true;
            }
            return false;
        }

        private static bool archerLose(double health)
        {
            if (health == 0)
            {
                Console.WriteLine("Archer lose!");
                return true;
            }
            return false;
        }

      

        private static void reset()
        {
            mage1Health = 720;
            warrior1Health = 1150;
            archer1Health = 1000;

            mage1Attack = 291;
            warrior1Attack = 202;
            archer1Attack = 225;

            mage2Health = 720;
            warrior2Health = 1150;
            archer2Health = 1000;

            mage2Attack = 291;
            warrior2Attack = 202;
            archer2Attack = 225;

            player1Damage = 0;
            player2Damage = 0;
        }

        private static ConsoleColor greenBackGround()
        {
            return Console.ForegroundColor = ConsoleColor.Green;
        }

        private static ConsoleColor redBackGround()
        {
            return Console.ForegroundColor = ConsoleColor.Red;
        }

        private static void whiteBackGround()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

       
    }
}