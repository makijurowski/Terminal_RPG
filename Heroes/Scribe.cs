using System;

namespace terminal_rpg
{
    // Child class Scribe which inherits from Human
    public class Scribe : Human
    {
        // Constructor for Scribe which only takes name as parameter but sets new default for property of Human
        public Scribe(string name) : base(name)
        {
            ClassName = "Scribe";
            Health = 150;
        }

        // Method used for the Scribe to heal, increasing their health
        public void Write_Poetry()
        {
            Health += 15;
        }

        // Method used to attack another player (passed by reference)
        public void Quill_Stab(object obj)
        {
            Human enemy = obj as Human;
            if (enemy == null)
            {
                System.Console.WriteLine("Quill stab failed. This player does not exist.");
            }
            else
            {
                Attack(enemy);
            }
        }
    }
}