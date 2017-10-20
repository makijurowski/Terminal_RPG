using System;

namespace terminal_rpg
{
    class Samurai_Choices
    {
        public Samurai_Choices(string charName)
        {
            Samurai player = new Samurai(charName);
            System.Console.WriteLine("Current Player: {0}", player.ShowStatus());
        }
    }
}