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
                    System.Console.WriteLine("{0} has been rasied from the dead!", target.Name);
                }
            }
            else
            {
                System.Console.WriteLine("You do not have any {0}", ClassName);
            }
        }
    }
}