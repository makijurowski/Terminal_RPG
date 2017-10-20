using System;

namespace terminal_rpg
{
    class Human_Choices
    {
        public Human_Choices(string charName)
        {
            Human player = new Human(charName);
            System.Console.WriteLine("Current Player: {0}", player.ShowStatus());
        }
    }
}