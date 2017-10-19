using System;

namespace terminal_rpg
{
    // Child class Spider which inherits from Enemy
    public class Spider : Enemy
    {
        // Constructor for Spider
        public Spider(string name) : base(name)
        {
            Health = 200;
        }
    }
}