using System;

namespace terminal_rpg
{
    // Child class GiantBaby which inherits from Enemy
    public class GiantBaby : Enemy
    {
        // Constructor for GiantBaby
        public GiantBaby(string name) : base(name)
        {
            Health = 250;
        }
    }
}