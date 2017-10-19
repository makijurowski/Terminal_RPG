using System;

namespace terminal_rpg
{
    // Child class Wizard which inherits from Human
    public class Wizard : Human
    {
        // Constructor for Wizard that only takes in name as parameter but sets new defaults for other properties of type Human
        public Wizard(string name) : base(name)
        {
            ClassName = "Wizard";
            Intelligence = 25;
            Health = 50;
        }

        // Method used to restore health to the Wizard who invokes it
        public void Heal()
        {
            Health += Intelligence * 5;
        }

        // Method used to attack another player passed by reference
        public void Fireball(object obj)
        {
            Human enemy = obj as Human;
            Random random = new Random();
            if (enemy == null)
            {
                System.Console.WriteLine("Fireball failed. This player does not exist.");
            }
            else
            {
                enemy.Health -= random.Next(20, 51);
            }
        }
    }
}