using System;

namespace terminal_rpg
{
    
    public class Grenade : Item
    {
        public Grenade() : base(){

        }

        public void Use(object obj)
        {
            Human target = obj as Human;
            target.Health -= 60;

        }
        public void Use(object obj1, object obj2)
        {
            Human target1 = obj1 as Human;
            Human target2 = obj2 as Human;
            
            target1.Health -= 30;
            target2.Health -= 30;

        }
        public void Use(object obj1, object obj2, object obj3)
        {
            Human target1 = obj1 as Human;
            Human target2 = obj2 as Human;
            Human target3 = obj3 as Human;
            target1.Health -= 20;
            target2.Health -= 20;
            target3.Health -= 20;

        }
    }
}