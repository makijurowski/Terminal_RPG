using System;
// TO-DO: Change player as enemy to object of Enemy class

namespace terminal_rpg
{
    // Base parent class
    public class Human
    {
        // Properties for Human class
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
        public int Health { get; set; }

        // Constructor for Human class with default values added (only passes name as argument)
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }

        // Constructor for Human class without default values (passes all stats as arguments)
        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;
        }

        // Method to show the status of the current player
        public string ShowStatus()
        {
            if (Name.Length < 10)
            {
                int numSpaces = 10 - Name.Length;
                string space = " ";
                for (int i = 0; i < numSpaces; i++)
                {
                    space += " ";
                }
                Name = Name += space;
            }
            string status = String.Format("{0} (HEALTH: {1}; STRENGTH: {2}; DEXTERITY: {3}; INTELLIGENCE: {4})", 
                                          Name,
                                          Health, 
                                          Strength, 
                                          Dexterity, 
                                          Intelligence);
            return status;
        }

        // Method used to attack another player passed by reference
        public void Attack(object obj)
        {
            Human enemy = obj as Human;
            if (enemy == null)
            {
                System.Console.WriteLine("Attack failed. This player does not exist.");
            }
            else
            {
                enemy.Health -= Strength * 5;
            }
        }
    }
}