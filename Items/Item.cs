using System;


namespace terminal_rpg
{
    
    public class Item
    {
        public int Item_Count = 0;

    
    public Item()
    {
        Item_Count += 1;
    }
    public void Use() 
    {
        Item_Count -= 1;

    }
    public void Use(object obj) 
    {
        Item_Count -= 1;

    }
    public void Use(object obj1, object obj2) 
    {
        Item_Count -= 1;

    }
    public void Use(object obj1, object obj2, object obj3) 
    {
        Item_Count -= 1;

    }

    }
}