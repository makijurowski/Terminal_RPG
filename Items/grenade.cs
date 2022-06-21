using System;

namespace terminal_rpg
{
    public class Grenade : Item
    {
        public Grenade()
        {
            ClassName = "Grenades";
            Count = 0;
        }

        public void Use(object obj)
        {
            if (Count > 1)
            {
                Count -= 1;
                Human target = obj as Human;
                target.Health -= 60;
            }
            else
            {
                Console.WriteLine("You do not have any {0}", ClassName);
            }
        }

        public void Use(object obj1, object obj2)
        {
            if (Count > 1)
            {
                Count -= 1;
                Human target1 = obj1 as Human;
                Human target2 = obj2 as Human;

                target1.Health -= 30;
                target2.Health -= 30;
            }
            else
            {
                Console.WriteLine("You do not have any {0}", ClassName);
            }
        }

        public void Use(object obj1, object obj2, object obj3)
        {
            if (Count > 1)
            {
                Count -= 1;
                Human target1 = obj1 as Human;
                Human target2 = obj2 as Human;
                Human target3 = obj3 as Human;
                target1.Health -= 20;
                target2.Health -= 20;
                target3.Health -= 20;
            }
            else
            {
                Console.WriteLine("You do not have any {0}", ClassName);
            }
        }
    }
}