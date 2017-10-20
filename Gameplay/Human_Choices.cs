using System;
using System.Collections.Generic;

namespace terminal_rpg
{
    class Human_Choices
    {
        public Human_Choices(string charName)
        {
            Human player = new Human(charName);
            System.Console.WriteLine("\nHere are your starting stats...\n");
            System.Console.ReadKey();
            System.Console.WriteLine("Current Player: {0}", player.ShowStatus());
            System.Console.ReadKey();
            Human_Choices.Choose_Action(player);
        }

        public static void Choose_Action(Human player)
        {
            int numSelect;
            Goblin enemy = new Goblin("Goblix");
            System.Console.WriteLine("\nUh oh! Trouble's a-foot. A big, ugly, scary-looking thing appeared...");
            System.Console.WriteLine(Program.newLine);
            System.Console.ReadKey();
            System.Console.WriteLine("Your worst nightmare! It's {0} the {1}!", enemy.Name, enemy.ClassName);
            // Get user input for selection
            System.Console.ReadKey();
            System.Console.WriteLine(Program.newLine);
            System.Console.WriteLine("Now you must select a number to choose what you would like to do next.");
            System.Console.ReadKey();
            System.Console.WriteLine(Program.newLine);
            foreach (KeyValuePair<int, string> action in player.Actions)
            {
                System.Console.WriteLine("{0}. {1}\n", action.Key, action.Value);
            }
            numSelect = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(Program.newLine);

            switch(numSelect)
            {
                case 1:
                    System.Console.WriteLine("You chose to use {0} on {1} the {2}!", player.Actions[1], enemy.Name, enemy.ClassName);
                    player.Attack(enemy);
                    System.Console.WriteLine(Program.newLine);
                    System.Console.ReadKey();
                    System.Console.WriteLine("Your current stats: {0}\n", player.ShowStatus());
                    System.Console.WriteLine(Program.newLine);
                    System.Console.ReadKey();
                    System.Console.WriteLine("Enemy current stats: {0}\n", enemy.ShowStatus());
                    break;
                case 2:
                    System.Console.WriteLine("You chose {0}!", player.Actions[2]);
                    System.Console.ReadKey();
                    System.Console.WriteLine(Program.newLine);
                    System.Console.WriteLine("Your current stats: {0}\n", player.ShowStatus());
                    break;
                case 3:
                    System.Console.WriteLine("You chose to {0}!", player.Actions[3]);
                    System.Console.WriteLine(Program.newLine);
                    System.Console.ReadKey();
                    System.Console.WriteLine("You lost the game. Better luck next time.");
                    System.Console.WriteLine(Program.newLine);
                    System.Console.ReadKey();
                    System.Console.WriteLine("Just kidding! But why not try another choice? YOLO, amirite?");
                    System.Console.WriteLine(Program.newLine);
                    System.Console.ReadKey();
                    Human_Choices.Choose_Action(player);
                    break;
                case 4: 
                    System.Console.WriteLine("You chose to {0}!", player.Actions[4]);
                    System.Console.WriteLine(Program.newLine);
                    System.Console.ReadKey();
                    System.Console.WriteLine("Stashed away in your pockets, you currently possess:");
                    System.Console.WriteLine(Program.newLine);
                    foreach (KeyValuePair<string, int> item in player.Inventory)
                    {
                        System.Console.WriteLine("You have {0} {1}s.\n", item.Value, item.Key);
                    }
                    System.Console.WriteLine("Would you like to use one of your items?");
                    System.Console.WriteLine(Program.newLine);
                    System.Console.ReadKey();
                    System.Console.WriteLine("That's a shame. Go tell the game creators to make it happen!");
                    System.Console.WriteLine(Program.newLine);
                    System.Console.ReadKey();
                    Human_Choices.Choose_Action(player);
                    break;
                default:
                    System.Console.WriteLine("Learn how to number better!");
                    System.Console.ReadKey();
                    System.Console.WriteLine(Program.newLine);
                    Human_Choices.Choose_Action(player);
                    break;
            }
        }
    }
}