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
            Console.WriteLine($"INSTA KILL!!!! {target.Name} suddenly dropped dead.");
            }
            else{
                    Console.WriteLine($"You do not have any {ClassName}");
            }
        }//eom
    }//eoc
}//eon