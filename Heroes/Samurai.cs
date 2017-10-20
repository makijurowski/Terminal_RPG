using System;
using System.Collections.Generic;

namespace terminal_rpg
{
    // Child class Samurai which inherits from Human
    public class Samurai : Human
    {
        // Properties for the Samurai class
        public static int Samurai_Count = 0;
        public static Dictionary<int, string> Actions = new Dictionary<int, string>()
            {
                { 1, "Attack" },
                { 2, "Meditate" },
                { 3, "Death_Blow" },
                { 4, "How_Many" }
            };

        // Constructor for Samurai that only takes in name as parameter but sets new defaults for other properties of type Human
        public Samurai(string name) : base(name)
        {
            ClassName = "Samurai";
            Health = 200;
            Samurai_Count += 1;
            // Samurai_Actions = new Dictionary<int, string>()
            // {
            //     { 1, "Attack" },
            //     { 2, "Meditate" },
            //     { 3, "Death_Blow" },
            //     { 4, "How_Many" }
            // };
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