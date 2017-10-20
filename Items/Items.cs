using System;

namespace terminal_rpg
{
    public class Item
    {
        public string ClassName { get; set; }
        public int Count { get; set; }

        public Item()
        {
            ClassName = "Item";
        }

        public int Add(object obj)
        {
            Count += 1;
            Human player = obj as Human;
            player.Inventory[ClassName] = Count;
            return Count;
        }
        
        public void How_Many()
        {
            System.Console.WriteLine("Number of {0}: {1}", ClassName, Count);
        }
    }
}