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
            Console.WriteLine($"Current Player: {player.ShowStatus()}");
            Console.ReadKey();
            Choose_Action(player);
        }//end of Human_Choices

        public static void Choose_Action(Human player)
        {
            int numSelect;
            Goblin enemy = new ("Goblix");
            Console.WriteLine("\nUh oh! Trouble's a-foot. A big, ugly, scary-looking thing appeared...");
            Console.ReadKey();
            Console.WriteLine($"Your worst nightmare! It's {enemy.Name} the {enemy.ClassName}!");
            // Get user input for selection
            Console.ReadKey();
            Console.WriteLine("Now you must select a number to choose what you would like to do next.");
            Console.ReadKey();
            foreach (KeyValuePair<int, string> action in player.Actions)
            {
                Console.WriteLine($"{action.Key}. {action.Value}");
            }
            numSelect = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Program.newLine);

            switch(numSelect)
            {
                case 1:
                    Console.WriteLine($"You chose to use {player.Actions[1]} on {enemy.Name} the {enemy.ClassName}!");
                    player.Attack(enemy);
                    Console.ReadKey();
                    Console.WriteLine($"Your current stats: {player.ShowStatus()}\n");
                    Console.ReadKey();
                    Console.WriteLine($"Enemy current stats: {enemy.ShowStatus()}\n");
                    break;
                case 2:
                    Console.WriteLine($"You chose {player.Actions[2]}!");
                    Console.ReadKey();
                    Console.WriteLine($"Your current stats: {player.ShowStatus()}\n");
                    break;
                case 3:
                    Console.WriteLine($"You chose to {player.Actions[3]}!");
                    Console.ReadKey();
                    Console.WriteLine("You lost the game. Better luck next time.");
                    Console.ReadKey();
                    Console.WriteLine("Just kidding! But why not try another choice? YOLO, amirite?");
                    Console.ReadKey();
                    Choose_Action(player);
                    break;
                case 4: 
                    Console.WriteLine($"You chose to {player.Actions[4]}!");
                    Console.ReadKey();
                    Console.WriteLine("Stashed away in your pockets, you currently possess:");
                    foreach (KeyValuePair<string, int> item in player.Inventory)
                    {
                        Console.WriteLine($"You have {item.Value} {item.Key}s.");
                    }
                    Console.WriteLine("Would you like to use one of your items?");
                    Console.ReadKey();
                    Console.WriteLine("That's a shame. Go tell the game creators to make it happen!");
                    Console.ReadKey();
                    Choose_Action(player);
                    break;
                default:
                    Console.WriteLine("Learn how to number better!");
                    Console.ReadKey();
                    Choose_Action(player);
                    break;
            }//end switch
        }//end of Choose_Action
    }//eoc
}//eon