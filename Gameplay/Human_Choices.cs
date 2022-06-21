using System;
using System.Collections.Generic;

namespace terminal_rpg
{
    class Human_Choices
    {
        public Human_Choices(string charName)
        {
            Human player = new (charName);
            Console.WriteLine("\nHere are your starting stats...\n");
            Console.ReadKey();
            Console.WriteLine("Current Player: {0}", player.ShowStatus());
            Console.ReadKey();
            Human_Choices.Choose_Action(player);
        }

        public static void Choose_Action(Human player)
        {
            int numSelect;
            Goblin enemy = new ("Goblix");
            Console.WriteLine("\nUh oh! Trouble's a-foot. A big, ugly, scary-looking thing appeared...");
            Console.ReadKey();
            Console.WriteLine("Your worst nightmare! It's {0} the {1}!", enemy.Name, enemy.ClassName);
            // Get user input for selection
            Console.ReadKey();
            Console.WriteLine("Now you must select a number to choose what you would like to do next.");
            Console.ReadKey();
            foreach (KeyValuePair<int, string> action in player.Actions)
            {
                Console.WriteLine("{0}. {1}\n", action.Key, action.Value);
            }
            numSelect = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Program.newLine);

            switch(numSelect)
            {
                case 1:
                    Console.WriteLine("You chose to use {0} on {1} the {2}!", player.Actions[1], enemy.Name, enemy.ClassName);
                    player.Attack(enemy);
                    Console.ReadKey();
                    Console.WriteLine("Your current stats: {0}\n", player.ShowStatus());
                    Console.ReadKey();
                    Console.WriteLine("Enemy current stats: {0}\n", enemy.ShowStatus());
                    break;
                case 2:
                    Console.WriteLine("You chose {0}!", player.Actions[2]);
                    Console.ReadKey();
                    Console.WriteLine("Your current stats: {0}\n", player.ShowStatus());
                    break;
                case 3:
                    Console.WriteLine("You chose to {0}!", player.Actions[3]);
                    Console.ReadKey();
                    Console.WriteLine("You lost the game. Better luck next time.");
                    Console.ReadKey();
                    Console.WriteLine("Just kidding! But why not try another choice? YOLO, amirite?");
                    Console.ReadKey();
                    Human_Choices.Choose_Action(player);
                    break;
                case 4: 
                    Console.WriteLine("You chose to {0}!", player.Actions[4]);
                    Console.ReadKey();
                    Console.WriteLine("Stashed away in your pockets, you currently possess:");
                    foreach (KeyValuePair<string, int> item in player.Inventory)
                    {
                        Console.WriteLine("You have {0} {1}s.\n", item.Value, item.Key);
                    }
                    Console.WriteLine("Would you like to use one of your items?");
                    Console.ReadKey();
                    Console.WriteLine("That's a shame. Go tell the game creators to make it happen!");
                    Console.ReadKey();
                    Human_Choices.Choose_Action(player);
                    break;
                default:
                    Console.WriteLine("Learn how to number better!");
                    Console.ReadKey();
                    Human_Choices.Choose_Action(player);
                    break;
            }
        }
    }
}