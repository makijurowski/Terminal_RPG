using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terminal_rpg
{
    // Make a new character based on player's choice
    public class MakeChar
    {
        public MakeChar(int numSelect, string charName)
        {
            int Choice = numSelect;
            string CharName = charName;

            switch (Choice)
            {
                case 1:
                    Console.WriteLine("You chose to live it up as a human in a fantasy game!");
                    Console.ReadKey();
                    Human_Choices humanPlayer = new(charName);
                    break;
                case 2:
                    Console.WriteLine("You chose wizard!");
                    Console.ReadKey();
                    Wizard_Choices wizardPlayer = new(charName);
                    break;
                case 3:
                    Console.WriteLine("You chose samurai!");
                    Console.ReadKey();
                    Samurai_Choices samuraiPlayer = new(charName);
                    break;
                case 4:
                    Console.WriteLine("You chose ninja!");
                    Console.ReadKey();
                    Ninja_Choices ninjaPlayer = new(charName);
                    break;
                default:
                    Console.WriteLine("You entered an invalid choice. Please try again.");
                    Console.ReadKey();
                    numSelect = Convert.ToInt32(Console.ReadLine());
                    MakeChar player = new(numSelect, charName);
                    break;
            }
        }
    }
}
