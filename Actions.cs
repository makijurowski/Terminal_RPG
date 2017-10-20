using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace terminal_rpg
{
    public class MakeChar
    {
        public MakeChar(int numSelect, string charName)
        {
            int Choice = numSelect;
            string CharName = charName;

            switch(Choice)
            {
                case 1:
                    System.Console.WriteLine("You chose human!");
                    Human_Choices humanPlayer = new Human_Choices(charName);
                    break;
                case 2:
                    System.Console.WriteLine("You chose wizard!");
                    Wizard_Choices wizardPlayer = new Wizard_Choices(charName);
                    break;
                case 3:
                    System.Console.WriteLine("You chose samurai!");
                    Samurai_Choices samuraiPlayer = new Samurai_Choices(charName);
                    break;
                case 4:
                    System.Console.WriteLine("You chose ninja!");
                    Ninja_Choices ninjaPlayer = new Ninja_Choices(charName);
                    break;
                default:
                    System.Console.WriteLine("You entered an invalid choice. Please try again.");
                    numSelect = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine(Program.newLine);
                    MakeChar player = new MakeChar(numSelect, charName);
                    break;
            }
        }
    }
}