using CIS129FinalProject;
using System.Reflection.Metadata;


bool attackGoblin = Dungeon.encounterGoblin();
bool attackBanshee = Dungeon.encounterBanshee();
bool attackOrc = Dungeon.encounterOrc();
bool takeHealthPotion = Dungeon.seeHealthPotion();
bool takeMagickaPotion = Dungeon.seeMagickaPotion();
bool WizertIsFree = Dungeon.reachExitLocation();
string userInput = "y";

do
{
    if (attackGoblin)
    {
        Console.WriteLine("You have encountered a Goblin");
        Console.WriteLine($"It's the current HP {Enemy._hpGoblin}.");
        Console.WriteLine("Press...\n" +
            "1.To Attack\n" +
            "2.To Heal\n" +
            "3.To Attempt to Flee");
        Console.WriteLine();
        string option = Console.ReadLine();
        if (option == "1")
        {
            while (Enemy._hpGoblin > 1)
            {
                Wizert._hpWizert -= 5;  
                Wizert._mpWizert -= 3; 
                //Enemy._hpGoblin -= 5;
            }
            Console.WriteLine("Attend Fireball attack\nIt had damage Goblin 3 Hp ");
            Console.WriteLine($"You have defeated Goblin\nWizert current Health is {Wizert._hpWizert}\n");
            userInput = "y";
        }
        else if (option == "2")
        {
            Wizert._mpWizert -= 5;
            Wizert._hpWizert += 3;
            Console.WriteLine($"Wizert current Hp {Wizert._hpWizert} and current Mp {Wizert._mpWizert}");
            userInput = "y";

        }
        else if (option == "3")
        {
            Console.WriteLine("Pick an option\n1.North\n2.South\n3.West\n4.East");
            string direction = Console.ReadLine();
            if (direction == "1")
            {
                Wizert.playerLocationX -= 1;
                userInput = "y";
            }
            else if (direction == "2")
            {
                Wizert.playerLocationY -= 1;
                userInput = "y";
            }
            else if (direction == "3")
            {
                Wizert.playerLocationX -= 1;
                Wizert.playerLocationY -= 1;
                userInput = "y";
            }
            else
            {
                Wizert.playerLocationY += 1;
                Wizert.playerLocationX += 1;
                userInput = "y";
            }
        }

    }
    else if (attackBanshee)
    {
        Console.WriteLine("You have encountered a Banshee");
        Console.WriteLine($"It's the current HP {Enemy._hpBanshee}.");
        Console.WriteLine("Press...\n" +
            "1.To Attack\n" +
            "2.To Heal\n" +
            "3.To Attempt to Flee");
        Console.WriteLine();
        string option = Console.ReadLine();
        if (option == "1")
        {
            while (Enemy._hpBanshee >= 0)
            {
                Wizert._hpWizert -= 5;  
                Wizert._mpWizert -= 3;  
                Enemy._hpBanshee -= 5;
            }
            Console.WriteLine("Attend Fireball attack\nIt had damage Banshee 8 Hp ");
            Console.WriteLine($"You have defeated Banshee\nWizert current Health is {Wizert._hpWizert}\n");
            userInput = "y";
        }
        else if (option == "2")
        {
            Wizert._mpWizert -= 5;
            Wizert._hpWizert += 3;
            Console.WriteLine($"Wizert current Hp {Wizert._hpWizert} and current Mp {Wizert._mpWizert}");
            userInput = "y";
        }
        else if (option == "3")
        {
            Console.WriteLine("Pick an option\n1.North\n2.South\n3.West\n4.East");
            string direction = Console.ReadLine();
            if (direction == "1")
            {
                Wizert.playerLocationX -= 1;
                userInput = "y";
            }
            else if (direction == "2")
            {
                Wizert.playerLocationY -= 1;
                userInput = "y";
            }
            else if (direction == "3")
            {
                Wizert.playerLocationX -= 1;
                Wizert.playerLocationY -= 1;
                userInput = "y";
            }
            else
            {
                Wizert.playerLocationY += 1;
                Wizert.playerLocationX += 1;
                userInput = "y";
            }
        }
    }
    else if (attackOrc)
    {
        Console.WriteLine("You have encountered a Goblin");
        Console.WriteLine($"It's the current HP {Enemy._hpOrc}.");
        Console.WriteLine("Press...\n" +
            "1.To Attack\n" +
            "2.To Heal\n" +
            "3.To Attempt to Flee");
        Console.WriteLine();
        string option = Console.ReadLine();
        if (option == "1")
        {
            while (Enemy._hpOrc >= 0)
            {
                Wizert._hpWizert -= 5;  
                Wizert._mpWizert -= 3;  
                Enemy._hpOrc -= 5;
            }
            Console.WriteLine("Attend Fireball attack\nIt had damage Orc 5 Hp ");
            Console.WriteLine($"You have defeated Orc\nWizert current Health is {Wizert._hpWizert}\n");
        }
        else if (option == "2")
        {
            Wizert._mpWizert -= 5;
            Wizert._hpWizert += 3;
            Console.WriteLine($"Wizert current Hp {Wizert._hpWizert} and current Mp {Wizert._mpWizert}");

        }
        else if (option == "3")
        {
            Console.WriteLine("Pick an option\n1.North\n2.South\n3.West\n4.East");
            string direction = Console.ReadLine();
            if (direction == "1")
            {
                Wizert.playerLocationX -= 1;
            }
            else if (direction == "2")
            {
                Wizert.playerLocationY -= 1;
            }
            else if (direction == "3")
            {
                Wizert.playerLocationX -= 1;
                Wizert.playerLocationY -= 1;
            }
            else
            {
                Wizert.playerLocationY += 1;
                Wizert.playerLocationX += 1;
            }
        }
    }
    else if (takeHealthPotion)
    {
        Console.WriteLine($"You have reach a health potion, your HP is {Wizert._hpWizert}");
        Wizert._hpWizert += 10;
        Console.WriteLine($"Now your current HP is {Wizert._hpWizert}");
    }
    else if (takeMagickaPotion)
    {
        Console.WriteLine($"You have reach a health potion, your HP is {Wizert._mpWizert}");
        Wizert._mpWizert += 20;
        Console.WriteLine($"Now your current HP is {Wizert._mpWizert}");
    }
    else if (WizertIsFree)
    {
        Console.WriteLine("Congradulation! You have escape the dungeon");
    }


    else
    {
        Console.WriteLine("Wizert have defeated. Will you like to play again?\n press 'y' to play again or press any key to exit. ");
        userInput = Console.ReadLine();
    }
}
while (userInput == "y" || userInput == "Y");