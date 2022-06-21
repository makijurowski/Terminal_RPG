using System;
using System.Collections.Generic;
// TO-DO: Change player as enemy to object of Enemy class

namespace terminal_rpg
{
    // Base parent class
    public class Human
    {
        // Properties for Human class
        public string ClassName { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
        public int Health { get; set; }
        public Dictionary<int, string> Actions { get; set; }
        public Dictionary<string, int> Inventory { get; set; }

        // Constructor for Human class with default values added (only passes name as argument)
        public Human(string name)
        {
            ClassName = "Human";
            Status = "standby";
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;

            Actions = new Dictionary<int, string>()
            {
                { 1, "Attack" },
                { 2, "Show Current Stats" },
                { 3, "Do Homework" },
                { 4, "Check Inventory" }
            };

            Inventory = new Dictionary<string, int>()
            {
                { "Enrage", 0 },
                { "Grenade", 2 },
                { "Heal_Potion", 3 },
                { "Insta_Kill", 0 },
                { "Revive", 1 }
            };
        }
        // Constructor for Human class without default values (passes all stats as arguments)
        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            ClassName = "Human";
            Status = "standby";
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;

            Actions = new Dictionary<int, string>()
            {
                { 1, "Attack" },
                { 2, "ShowStatus" }
            };
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
            string status = string.Format($"{Name} (Class: {ClassName}; Health: {Health}; Strength: {Strength}; Dexterity: {Dexterity}; Intelligence: {Intelligence};");
            return status;
        }

        // Method used to attack another player passed by reference
        public void Attack(object obj)
        {
            Human enemy = obj as Human;
            if (enemy == null)
            {
                Console.WriteLine("Attack failed. This player does not exist.");
            }
            else
            {
                enemy.Health -= Strength * 5;
            }
        }
    }
}