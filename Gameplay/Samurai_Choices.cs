using System;

namespace terminal_rpg
{
    class Samurai_Choices
    {
        public Samurai_Choices(string charName)
        {
            Samurai player = new Samurai(charName);
            Console.WriteLine($"Current Player: {player.ShowStatus()}");
        }
    }
}