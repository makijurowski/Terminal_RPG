using System;

namespace terminal_rpg
{
    class Ninja_Choices
    {
        public Ninja_Choices(string charName)
        {
            Ninja player = new (charName);
            Console.WriteLine($"Current Player: {player.ShowStatus()}");
        }
    }
}