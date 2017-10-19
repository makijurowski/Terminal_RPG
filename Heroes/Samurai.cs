using System;

namespace terminal_rpg
{
    // Child class Samurai which inherits from Human
    public class Samurai : Human
    {
        // Add a new property to Samurai to keep count for How_Many function
        public static int Samurai_Count = 0;

        // Constructor for Samurai that only takes in name as parameter but sets new defaults for other properties of type Human
        public Samurai(string name) : base(name)
        {
            Health = 200;
            Samurai_Count += 1;
        }

        // Method used to log the number of samurais that have been created
        public static void How_Many()
        {
            System.Console.WriteLine("Number of Samurais: {0}", Samurai_Count);
        }

        // Method used to restore health to the Samurai who invokes it
        public void Meditate()
        {
            Health = 200;
        }

        // Method used to attack another player passed by reference
        public void Death_Blow(object obj)
        {
            Human enemy = obj as Human;
            if (enemy == null)
            {
                System.Console.WriteLine("Death_Blow failed. This player does not exist.");
            }
            else if (enemy.Health < 50)
            {
                enemy.Health = 0;
            }
            else
            {
                System.Console.WriteLine("Death_Blow failed. This player has over 50 health.");
            }
        }
    }
}