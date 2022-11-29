using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CIS129FinalProject
{
    internal class Dungeon : Wizert
    {
        public Dungeon(int hpWizert, int mpWizert,
            int hpGoblin, int hpOrc, int hpBanshee,
            int GoblinAttackBodySlam, int OrcAttackCleave,
            int BansheeAttackScreech)
            : base(hpWizert, mpWizert,
                 hpGoblin, hpOrc, hpBanshee,
                 GoblinAttackBodySlam, OrcAttackCleave,
                 BansheeAttackScreech)
        {
            var location = new Random();

            var GoblinLocations = new List<int>();
            // Goblin has 5 locations
            for (int i = 0; i <= 4; i++)
            {
                GoblinLocations.Add(location.Next(0, 25));
            }

            var OrcLocation = new List<int>();
            // Orc 5 has locations
            for (int j = 0; j <= 4; j++)
            {
                OrcLocation.Add(location.Next(0, 25));
            }

            var BansheeLocation = new List<int>();
            // Banshee has 5 locations
            for (int k = 0; k <= 4; k++)
            {
                BansheeLocation.Add(location.Next(0, 25));
            }

            var WizertLocation = new List<int>();
            // Wizert has 15 locations
            for (int n = 0; n <= 14; n++)
            {
                WizertLocation.Add(location.Next(0, 25));
            }

            var HealthPotionLocation = new List<int>();
            // Health Potion has 5 locations
            for (int k = 0; k <= 4; k++)
            {
                HealthPotionLocation.Add(location.Next(0, 25));
            }

            var MagickaPotionLocation = new List<int>();
            // Magicka Potion has 5 locations
            for (int k = 0; k <= 4; k++)
            {
                MagickaPotionLocation.Add(location.Next(0, 25));
            }

            while (hpWizert >= 0)
            {
                // attacking Orc
                for (int k = 0; k <= WizertLocation.Count; k++)
                {
                    for (int j = 0; j <= OrcLocation.Count; j++)
                    {
                        if (k == j)
                        {
                            Console.WriteLine("You have encountered a Orc");
                            Console.WriteLine($"It's the current HP {hpOrc}.");
                            Console.WriteLine("Press...\n" +
                                "1.To Attack\n" +
                                "2.To Heal\n" +
                                "3.To Attempt to Flee");
                            Console.WriteLine();
                            string option = Console.ReadLine();
                            if (option == "1")
                            {
                                while (hpOrc >= 0)
                                {
                                    hpWizert -= 3;
                                    mpWizert -= 3;
                                    hpOrc -= 5;
                                }
                                Console.WriteLine("Attend Fireball attack\nIt had damage Orc 5 Hp ");
                                Console.WriteLine($"You have defeated Orc\nWizert current Health is {hpWizert}");
                            }
                            else if (option == "2")
                            {
                                mpWizert -= 5;
                                hpWizert += 3;
                                Console.WriteLine($"Wizert current Hp {hpWizert} and current Mp {mpWizert}");

                            }
                            else if (option == "3")
                            {
                                Console.WriteLine("Pick an option\n1.North\n2.South\n3.West\n4.East");
                                string direction = Console.ReadLine();
                                if (direction == "1" || direction == "2" || direction == "3" || direction == "4")
                                {
                                    WizertLocation[0] = WizertLocation[0] - 1;
                                }
                            }


                        }
                    }
                }
                // atttacking Goblin
                for (int k = 0; k <= WizertLocation.Count; k++)
                {
                    for (int j = 0; j <= GoblinLocations.Count; j++)
                    {
                        if (k == j)
                        {
                            Console.WriteLine("You have encountered a Goblin");
                            Console.WriteLine($"It's the current HP {hpGoblin}.");
                            Console.WriteLine("Press...\n" +
                                "1.To Attack\n" +
                                "2.To Heal\n" +
                                "3.To Attempt to Flee");
                            Console.WriteLine();
                            string option = Console.ReadLine();
                            if (option == "1")
                            {
                                while (hpGoblin >= 0)
                                {
                                    hpWizert -= 2;  // damage by Goblin
                                    mpWizert -= 3;  // cause 3 Mp to attack Fireball
                                    hpGoblin -= 5;
                                }
                                Console.WriteLine("Attend Fireball attack\nIt had damage Goblin 3 Hp ");
                                Console.WriteLine($"You have defeated Goblin\nWizert current Health is {hpWizert}");
                            }
                            else if (option == "2")
                            {
                                mpWizert -= 5;
                                hpWizert += 3;
                                Console.WriteLine($"Wizert current Hp {hpWizert} and current Mp {mpWizert}");

                            }
                            else if (option == "3")
                            {
                                Console.WriteLine("Pick an option\n1.North\n2.South\n3.West\n4.East");
                                string direction = Console.ReadLine();
                                if (direction == "1" || direction == "2" || direction == "3" || direction == "4")
                                {
                                    WizertLocation[0] = WizertLocation[0] - 1;
                                }
                            }
                        }
                    }
                }
                // attacking Banshee 
                for (int k = 0; k <= WizertLocation.Count; k++)
                {
                    for (int j = 0; j <= BansheeLocation.Count; j++)
                    {
                        if (k == j)
                        {
                            Console.WriteLine("You have encountered a Banshee");
                            Console.WriteLine($"It's the current HP {hpBanshee}.");
                            Console.WriteLine("Press...\n" +
                                "1.To Attack\n" +
                                "2.To Heal\n" +
                                "3.To Attempt to Flee");
                            Console.WriteLine();
                            string option = Console.ReadLine();
                            if (option == "1")
                            {
                                while (hpBanshee >= 0)
                                {
                                    hpWizert -= 5;  // damage by Banshee
                                    mpWizert -= 3;  // cause 3 Mp to attack Fireball
                                    hpBanshee -= 5;
                                }
                                Console.WriteLine("Attend Fireball attack\nIt had damage Banshee 8 Hp ");
                                Console.WriteLine($"You have defeated Banshee\nWizert current Health is {hpWizert}\n");
                            }
                            else if (option == "2")
                            {
                                mpWizert -= 5;
                                hpWizert += 3;
                                Console.WriteLine($"Wizert current Hp {hpWizert} and current Mp {mpWizert}");

                            }
                            else if (option == "3")
                            {
                                Console.WriteLine("Pick an option\n1.North\n2.South\n3.West\n4.East");
                                string direction = Console.ReadLine();
                                if (direction == "1" || direction == "2" || direction == "3" || direction == "4")
                                {
                                    WizertLocation[0] = WizertLocation[0] - 1;
                                }
                            }
                        }
                    }
                }
                // Wizert and Health Potion at the same location
                for (int k = 0; k <= WizertLocation.Count; k++)
                {
                    for (int j = 0; j <= HealthPotionLocation.Count; j++)
                    {
                        if (k == j)
                        {
                            hpWizert += 10;
                        }
                    }
                }
                // Wizert and Magicka Potion at the same location
                for (int k = 0; k <= WizertLocation.Count; k++)
                {
                    for (int j = 0; j <= GoblinLocations.Count; j++)
                    {
                        if (k == j)
                        {
                            mpWizert += 20;
                        }
                    }
                }
            }
            Console.WriteLine("Wizert have defeated. Will you like to play again?\n press 'y' to play again or press any key to exit. ");
            string userInput = Console.ReadLine();
            while (userInput == "y")
            {
                hpWizert = 100;
                mpWizert = 200;
            }
            Console.WriteLine("Thank you for playing Wizert 5");
        }
    }
}
