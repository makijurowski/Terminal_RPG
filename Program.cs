using System;

namespace terminal_rpg
{
    class Program
    {
        // Method used to invoke a new game and select a character
        public void Start_Game()
        {
            int numSelect;
            string newLine = "\n";

            // Greeting for player
            System.Console.WriteLine(newLine);
            System.Console.WriteLine("Welcome to Dojo Adventures!");
            System.Console.WriteLine(newLine);
            System.Console.WriteLine("Are you ready to play Dojo Adventures? Get hyped...");
            System.Console.WriteLine(newLine);
            System.Console.WriteLine("Please enter a number to choose which character you would like to play.");
            System.Console.WriteLine(newLine);
            System.Console.WriteLine("1. Human");
            System.Console.WriteLine("2. Wizard");
            System.Console.WriteLine("3. Samurai");
            System.Console.WriteLine("4. Ninja");
            System.Console.WriteLine(newLine);

            // Get player input
            numSelect = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(newLine);

            CharChoice player = new CharChoice(numSelect);
        }

        // Main method invoked upon running program
        static void Main(string[] args)
        {

            // // Create new player of class Human
            // Human me = new Human("Maki");
            // me.Health = 200;

            Program New_Game = new Program();
            New_Game.Start_Game();

            System.Console.WriteLine("\n");

        }
    }
}