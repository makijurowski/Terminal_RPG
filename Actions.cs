using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace terminal_rpg
{
    public class Actions
    {
        // Properties for Actions class
        public string Player { get; set; }
        public List<string> PlayerActions { get; set; }
        public Dictionary<int, string> KeyMap { get; set; }

        // Constructor for Actions class
        // public Actions(string player)
        public Actions()
        {
            // Player = player;
            var methods = typeof(Human).GetMethods(System.Reflection.BindingFlags.Public);
            var methods2 = typeof(Human).GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);
            // var methods2 = typeof(Human).GetMethods();
            System.Console.WriteLine(methods.Length);
            System.Console.WriteLine(methods2.Length);
        }
    }
}