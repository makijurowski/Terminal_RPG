using System;

namespace terminal_rpg
{
    class Wizard_Choices
    {
        public Wizard_Choices(string charName)
        {
            Wizard player = new Wizard(charName);
            Console.WriteLine($"Current Player: {player.ShowStatus()}");
        }
    }
}