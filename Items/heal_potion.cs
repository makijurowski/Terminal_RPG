using System;

namespace terminal_rpg
{
    
    public class Heal_Potion : Item
    {
        public Heal_Potion() : base(){

        }

        public void Use(object obj)
        {
            Human target = obj as Human;
            target.Health += 15;
            System.Console.WriteLine("{0} received +15 hp", target.Name);

        }
    }
}