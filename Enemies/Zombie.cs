using System;

namespace terminal_rpg
{
    // Child class Zombie which inherits from Enemy
    public class Zombie : Enemy
    {
        // Constructor for Zombie
        public Zombie(string name) : base(name)
        {
            Health = 300;
        }
    }
}