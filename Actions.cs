using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace terminal_rpg
{
    public class CharChoice
    {
        // Constructor
        public CharChoice(int numSelect)
        {
            int Choice = numSelect;
            switch(Choice)
            {
                case 1:
                    System.Console.WriteLine("You chose human!");
                    break;
                case 2:
                    System.Console.WriteLine("You chose wizard!");
                    break;
                case 3:
                    System.Console.WriteLine("You chose samurai!");
                    break;
                case 4:
                    System.Console.WriteLine("You chose ninja!");
                    break;
                default:
                    System.Console.WriteLine("You entered an invalid choice.");
                    break;
            }
        }
    }
}