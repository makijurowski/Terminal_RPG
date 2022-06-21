using System;

namespace terminal_rpg
{
    class Program
    {
        // Variable to hold string for new line formatting of output
        public static string newLine = "\n";

        // Method used to invoke a new game and select a character
        public void Start_Game()
        {
            int numSelect;
            string charName;

            // Script for starting the game
            Console.WriteLine("\nFirst things first. Let's get acquainted!");
            Console.ReadKey();
            Console.Write("What's your favorite color? ");
            // Intentionally does nothing
            Console.ReadLine();
            Console.WriteLine("Hmm... well that's a, uh, choice now, isn't it? Maybe we should try an easier one.\n");
            Console.ReadKey();
            Console.Write("So what's your name? ");
            // User input for name
            charName = Console.ReadLine();
            Console.WriteLine($"Great job {charName}, I knew you could do it!");
            Console.ReadKey();
            Console.WriteLine("Now, please enter a number to choose which character you would like to play.");
            Console.WriteLine("1. Human");
            Console.WriteLine("2. Wizard");
            Console.WriteLine("3. Samurai");
            Console.WriteLine("4. Ninja");
            Console.Write("Select: ");
            // User input for character class
            numSelect = Convert.ToInt32(Console.ReadLine());
            MakeChar player = new (numSelect, charName);
        }      

        // Main method invoked upon running program
        static void Main(string[] args)
        {
            var nameArr = new[]
            {@"                                                                                  ",
             @"                                                                                  ",
             @"                                                                                  ",
             @"   _____          _                                                               ",
             @"  |  __ \        (_)                                                              ",
             @"  | |  | |  ___   _   ___                                                         ",
             @"  | |  | | / _ \ | | / _ \                                                        ",                        
             @"  | |__| || (_) || || (_) |                                                       ",
             @"  |_____/  \___/ | | \___/   _                     _                              ",
             @"                _/ /\       | |                   | |                             ",
             @"               |__/  \    __| |__   __ ___  _ __  | |_  _   _  _ __  ___  ___     ",
             @"                 / /\ \  / _` |\ \ / // _ \| '_ \ | __|| | | || '__|/ _ \/ __|    ",
             @"                / ____ \| (_| | \ V /|  __/| | | || |_ | |_| || |  |  __/\__ \    ",
             @"               /_/    \_\\__,_|  \_/  \___||_| |_| \__| \__,_||_|   \___||___/    ",
             @"                                                                                  ",
             @"                                                                                  ",
             @"                                                                                  ",
             @"                                                                                  ",
             @"           Press any key to begin the best two minutes of your life.              ",
             @"                                                                                  ",
             @"                                                                                  ",
             @"                                                                                  ",
            };
            // Console.WindowWidth = 160;
            Console.WriteLine("\n\n");
            foreach (string line in nameArr)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();
            // Greeting for player
            Console.WriteLine(newLine);
            Console.WriteLine("Welcome to Dojo Adventures!");
            Console.ReadKey();
            Console.WriteLine("Are you ready to play Dojo Adventures? Get your hype pants on...\n");
            Console.ReadKey();

            // Initiate a new Game
            Program New_Game = new ();
            New_Game.Start_Game();
        }
    }
}