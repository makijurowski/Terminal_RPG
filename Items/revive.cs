using System;

namespace terminal_rpg
{
    public class Revive : Item
    {
        public Revive()
        {
            ClassName = "Revive";
        }

        public void Use(object obj)
        {
            if (Count > 1)
            {
                Human target = obj as Human;
                if (target.Status == "dead")
                {
                    target.Status = "standby";
                    target.Health = 100;
                    Count -= 1;
                }
                else
                {
                    Console.WriteLine($"{target.Name} has been rasied from the dead!");
                }
            }
            else
            {
                Console.WriteLine($"You do not have any {ClassName}");
            }
        }//eom
    }//eoc
}//eon