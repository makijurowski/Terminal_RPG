using System;

namespace terminal_rpg
{
    // Child class Goblin which inherits from Enemy
    public class Goblin : Enemy
    {
        // Constructor for Goblin
        public Goblin(string name) : base(name)
        {
            ClassName = "Goblin";
            Health = 250;
        }
    }
}