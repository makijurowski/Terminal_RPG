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
        public Actions(string player)
        {
            Player = player;
            // var methods = typeof(Human).GetMethods(System.Reflection.BindingFlags.Public);
        }
    }

}