using System;

namespace terminal_rpg
{
    // Child class Ninja which inherits from Human
    public class Ninja : Human
    {
        // Constructor for Ninja which only takes name as parameter but sets new default for property of Human
        public Ninja(string name) : base(name)
        {
            ClassName = "Ninja";
            Dexterity = 75;
        }

        // Method used for the Ninja to escape, decreasing their health
        public void Get_Away()
        {
            Health -= 15;
        }

        // Method used to attack another player (passed by reference) and restore health to Ninja who invokes it
        public void Steal(object obj)
        {
            Human enemy = obj as Human;
            if (enemy == null)
            {
                System.Console.WriteLine("Steal failed. This player does not exist.");
            }
            else
            {
                Attack(enemy);
                Health += 10;
            }
        }
    }
}