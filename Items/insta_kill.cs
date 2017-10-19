using System;

namespace terminal_rpg
{
    public class Insta_Kill : Item
    {
        public Insta_Kill(){
            ClassName = "Insta_Kill";
        }

        public void Use(object obj)
        {
            if (Count > 1)
            {
            Count -= 1;
            Human target = obj as Human;
            target.Health = 0;
            System.Console.WriteLine("INSTA KILL!!!! {0} suddenly dropped dead.", target.Name);
            }
            else{
                    System.Console.WriteLine("You do not have any {0}", ClassName);
            }
        }
    }
}