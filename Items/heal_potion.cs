using System;

namespace terminal_rpg
{
    public class Heal_Potion : Item
    {
        public Heal_Potion(){
            ClassName = "Heal_Potions";
        }

        public void Use(object obj)
        {
            if (Count > 1)
            {
            Count -= 1;
            Human target = obj as Human;
            target.Health += 15;
            Console.WriteLine("{0} received +15 hp", target.Name);
            }
            else{
                    Console.WriteLine("You do not have any {0}", ClassName);
            }
        }
    }
}