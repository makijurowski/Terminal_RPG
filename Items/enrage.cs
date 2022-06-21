using System;

namespace terminal_rpg
{
    public class Enrage : Item
    {
        public Enrage()
        {
            ClassName = "Enrage";
        }

        public void Use(object obj)
        {
            if (Count > 1)
            {
                Count -= 1;
                Human target = obj as Human;
                target.Health -= 10;
                target.Strength += 3;
                target.Intelligence -= 1;
                target.Dexterity -= 1;
                Console.WriteLine($"{target.Name} became ENRAGED! Strength was increased, but Intelligence, Dexterity, and Health took a hit...");
            }
            else
            {
                Console.WriteLine($"You do not have any {ClassName}");
            }
        }//eom
    }//eoc
}//eon