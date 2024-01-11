using System.Collections.Specialized;

namespace Myspace
{
    enum Attack
    {
        Physical,
        Magical
    };

    class Program
    {
        private static int mage1Health = 85;
        private static int warrior1Health = 105;
        private static int archer1Health = 95;

        private static int mage1Attack = 25;
        private static int warrior1Attack = 30;
        private static int archer1Attack = 20;

        private static int mage2Health = 85;
        private static int warrior2Health = 105;
        private static int archer2Health = 95;

        private static int mage2Attack = 25;
        private static int warrior2Attack = 30;
        private static int archer2Attack = 20;

        private static int choose;
        private static int choose2;

        private static int weather;
        private static int location;

        private static string start;
        private static int round = 1;
        public static void Main(String[] args)
        {
            Warrior warrior1 = new Warrior("Warrior", 105, 30, 10, 10);
            Mage mage1 = new Mage("Mage", 85, 25, 5, 10);
            Archer archer1 = new Archer("Archer", 95, 20, 10, 10);

            Warrior warrior2 = new Warrior("Warrior", 105, 30, 10, 10);
            Mage mage2 = new Mage("Mage", 85, 25, 5, 10);
            Archer archer2 = new Archer("Archer", 95, 20, 10, 10);

           

           




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
                round++;

                chooseWeatherAndLocation();

                chooseHero();


                int strategy = 0;
                Console.WriteLine();//////////////////

                if (choose == 1 && choose2 == 2)
                {
                    for (int i = 0; i < 99; i++)
                    {
                        if (warrior1Health <= 0)
                        {
                            Console.WriteLine("Mage win");
                            break;
                        }
                        else if (mage1Health <= 0)
                        {
                            Console.WriteLine("Warrior win");
                            break;
                        }
                        mage1Health -= mage1.Attack(warrior1Attack, Attack.Physical, 1, weather);
                        warrior1Health -= warrior1.Attack(mage1Attack, Attack.Magical, 1, weather);
                        Console.WriteLine($"Warrior health: {warrior1Health}");
                        Console.WriteLine($"Mage health: {mage1Health}");
                        Console.WriteLine();
                    }
                    warrior1Health = 105;
                    mage1Health = 85;
                }
                else if (choose == 2 && choose2 == 1)
                {
                    for (int i = 0; i < 99; i++)
                    {
                        if (mage1Health <= 0)
                        {
                            Console.WriteLine("Warrior win");
                            break;
                        }
                        else if (warrior1Health <= 0)
                        {
                            Console.WriteLine("Mage win");
                            break;
                        }
                        mage1Health -= mage1.Attack(warrior1Attack, Attack.Physical, 1, weather);
                        warrior1Health -= warrior1.Attack(mage1Attack, Attack.Magical, 1, weather);
                        Console.WriteLine($"Warrior health: {warrior1Health}");
                        Console.WriteLine($"Mage health: {mage1Health}");
                        Console.WriteLine();
                    }
                    warrior1Health = 105;
                    mage1Health = 85;
                }
                else if (choose == 1 && choose2 == 3)
                {
                    for (int i = 0; i < 99; i++)
                    {
                        if (archer1Health <= 0)
                        {
                            Console.WriteLine("Mage win");
                            break;
                        }
                        else if (mage1Health <= 0)
                        {
                            Console.WriteLine("Archer win");
                            break;
                        }
                        archer1Health -= archer1.Attack(mage1Attack, Attack.Magical, 1, weather);
                        mage1Health -= mage1.Attack(archer1Attack, Attack.Physical, 1, weather);

                        Console.WriteLine($"Archer health: {archer1Health}");
                        Console.WriteLine($"Mage health: {mage1Health}");
                        Console.WriteLine();
                    }
                    archer1Health = 95;
                    mage1Health = 85;
                }
                else if (choose == 3 && choose2 == 1)
                {
                    for (int i = 0; i < 99; i++)
                    {
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
                        mage1Health -= mage1.Attack(archer1Attack, Attack.Physical, 1, weather);
                        archer1Health -= archer1.Attack(mage1Attack, Attack.Magical, 1, weather);
                        Console.WriteLine($"Archer health: {archer1Health}");
                        Console.WriteLine($"Mage health: {mage1Health}");
                        Console.WriteLine();

                    }
                    archer1Health = 95;
                    mage1Health = 85;
                }
                else if (choose == 2 && choose2 == 3)
                {
                    for (int i = 0; i < 99; i++)
                    {
                        if (archer1Health <= 0)
                        {
                            Console.WriteLine("Warrior win");
                            break;
                        }
                        else if (warrior1Health <= 0)
                        {
                            Console.WriteLine("Archer win");
                            break;
                        }
                        archer1Health -= archer1.Attack(warrior1Attack, Attack.Physical, 1, weather);
                        warrior1Health -= warrior1.Attack(archer1Attack, Attack.Physical, 1, weather);
                        Console.WriteLine($"Archer health: {archer1Health}");
                        Console.WriteLine($"Warrior health: {warrior1Health}");
                        Console.WriteLine();
                    }
                    archer1Health = 95;
                    warrior1Health = 105;
                }
                else if (choose == 3 && choose2 == 2)
                {
                    for (int i = 0; i < 99; i++)
                    {
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
                        warrior1Health -= warrior1.Attack(archer1Attack, Attack.Physical, 1, weather);
                        archer1Health -= archer1.Attack(warrior1Attack, Attack.Physical, 1, weather);
                        Console.WriteLine($"Archer health: {archer1Health}");
                        Console.WriteLine($"Warrior health: {warrior1Health}");
                        Console.WriteLine();
                    }
                    archer1Health = 95;
                    warrior1Health = 105;
                }
                else if (choose == 1 && choose2 == 1)
                {
                    Console.WriteLine("123");
                    for (int i = 0; i < 99; i++)
                    {
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
                        mage2Health -= mage2.Attack(mage1Attack, Attack.Magical, 1, weather);
                        mage1Health -= mage1.Attack(mage2Attack, Attack.Magical, 1, weather);
                        Console.WriteLine($"Mage 1 health: {mage1Health}");
                        Console.WriteLine($"Mage 2 health: {mage2Health}");
                        Console.WriteLine("123");
                    }
                    mage1Health = 85;
                    mage2Health = 85;
                }
                else if (choose == 2 && choose2 == 2)
                {
                    for (int i = 0; i < 99; i++)
                    {
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
                        warrior2Health -= warrior2.Attack(warrior1Attack, Attack.Physical, 1, weather);
                        warrior1Health -= warrior1.Attack(warrior2Attack, Attack.Physical, 1, weather);
                        Console.WriteLine($"Warrior 1 health: {warrior1Health}");
                        Console.WriteLine($"Warrior 2 health: {warrior2Health}");
                        Console.WriteLine();
                    }
                    warrior1Health = 105;
                    warrior2Health = 105;
                }
                else if (choose == 3 && choose2 == 3)
                {
                    for (int i = 0; i < 99; i++)
                    {
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
                        archer2Health -= archer2.Attack(archer1Attack, Attack.Physical, 1, weather);
                        archer1Health -= archer1.Attack(archer2Attack, Attack.Physical, 1, weather);
                        Console.WriteLine($"Archer 1 health: {archer1Health}");
                        Console.WriteLine($"Archer 2 health: {archer2Health}");
                        Console.WriteLine();
                    }
                    archer1Health = 95;
                    archer2Health = 95;
                }


            } while (start != "n");

        }

        private static void chooseWeatherAndLocation()
        {
            
            Console.WriteLine("Choose location(1 - field, 2 - city, 3 - mountain, 4 - random)");
            location = Int32.Parse(Console.ReadLine());
            if (location == 4)
            {
                Random random = new Random();
                location = random.Next(1, 3);
            }

            Console.WriteLine("Choose weather(1 - rain, 2 - storm, 3 - snow, 4 - random)");
            weather = Int32.Parse(Console.ReadLine());
            if (weather == 1)
            {
                mage1Attack -= 3;
                warrior1Attack -= 2;
                archer1Attack -= 2;
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
            if (weather == 4)
            {
                Random random = new Random();
                weather = random.Next(1, 3);
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
    }
}