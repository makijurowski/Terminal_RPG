using System;
 
 namespace terminal_rpg {
     // Child class Enemy which inherits from Human
     public class Enemy : Human {
         // Constructor for Enemy
         public Enemy(string name) : base(name) {
             Strength = 5;
             Dexterity = 5;
             Intelligence = 5;
             Health = 100;
         }
     }
 } 