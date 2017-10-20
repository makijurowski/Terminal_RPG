using System;

namespace terminal_rpg
{
    class Wizard_Choices
    {
        public Wizard_Choices(string charName)
        {
            Wizard player = new Wizard(charName);
            System.Console.WriteLine("Current Player: {0}", player.ShowStatus());
        }
    }
}