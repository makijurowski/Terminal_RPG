using System;

namespace terminal_rpg
{
    class Program
    {
        // Variable to hold string for new line formatting of output
        public static object obj;
        public static string newLine = "\n";

        // Method used to invoke a new game and select a character
        public void Start_Game()
        {
            int numSelect;
            string charName;

            // Script for starting the game
            System.Console.WriteLine("\nFirst things first. Let's get acquainted!");
            System.Console.ReadKey();
            System.Console.WriteLine("What's your favorite color?");
            // Intentionally does nothing
            Console.ReadLine();
            System.Console.WriteLine("Hmm... well that's a, uh, choice now, isn't it? Maybe we should try an easier one.\n");
            System.Console.ReadKey();
            System.Console.WriteLine("So what's your name?");
            // User input for name
            charName = Console.ReadLine();
            System.Console.WriteLine("Great job {0}, I knew you could do it!", charName);
            System.Console.ReadKey();
            System.Console.WriteLine("Now, please enter a number to choose which character you would like to play.");
            System.Console.WriteLine("1. Human");
            System.Console.WriteLine("2. Wizard");
            System.Console.WriteLine("3. Samurai");
            System.Console.WriteLine("4. Ninja");
            // User input for character class
            numSelect = Convert.ToInt32(Console.ReadLine());
            MakeChar player = new MakeChar(numSelect, charName);
        }

        public class MakeEnemy
        {
            public string Name { get; set; }
            public string ClassName { get; set; }
            
            public MakeEnemy()
            {
                string[] names = {"Carl", "Samantha", "Robocop", "Blaine", "Roblox", "Goblix", "Jimmy", "Mr. Spanx"};
                Random random = new Random();
                int randomChance = random.Next(1, 5);
                int randomName = random.Next(1, 10);

                switch(randomChance)
                {
                    case 1:
                        Goblin goblinEnemy = new Goblin(names[randomName]);
                        obj = goblinEnemy;
                        break;
                    case 2:
                        Spider spiderEnemy = new Spider(names[randomName]);
                        obj = spiderEnemy;
                        break;
                    case 3:
                        Zombie zombieEnemy = new Zombie(names[randomName]);
                        obj = zombieEnemy;
                        break;
                    case 4:
                        GiantBaby giantBabyEnemy = new GiantBaby(names[randomName]);
                        obj = giantBabyEnemy;
                        break;
                }
            }
        }

        // Make a new character based on player's choice
        public class MakeChar
        {
            public MakeChar(int numSelect, string charName)
            {
                int Choice = numSelect;
                string CharName = charName;

                switch(Choice)
                {
                    case 1:
                        System.Console.WriteLine("You chose to live it up as a human in a fantasy game!");
                        System.Console.ReadKey();
                        Human_Choices humanPlayer = new Human_Choices(charName);
                        break;
                    case 2:
                        System.Console.WriteLine("You chose wizard!");
                        System.Console.ReadKey();
                        Wizard_Choices wizardPlayer = new Wizard_Choices(charName);
                        break;
                    case 3:
                        System.Console.WriteLine("You chose samurai!");
                        System.Console.ReadKey();
                        Samurai_Choices samuraiPlayer = new Samurai_Choices(charName);
                        break;
                    case 4:
                        System.Console.WriteLine("You chose ninja!");
                        System.Console.ReadKey();
                        Ninja_Choices ninjaPlayer = new Ninja_Choices(charName);
                        break;
                    default:
                        System.Console.WriteLine("You entered an invalid choice. Please try again.");
                        System.Console.ReadKey();
                        numSelect = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine(Program.newLine);
                        MakeChar player = new MakeChar(numSelect, charName);
                        break;
                }
            }
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
            // System.Console.WindowWidth = 160;
            System.Console.WriteLine("\n\n");
            foreach (string line in nameArr)
            {
                System.Console.WriteLine(line);
            }
            System.Console.ReadKey();
            // Greeting for player
            System.Console.WriteLine(newLine);
            System.Console.WriteLine("Welcome to Dojo Adventures!");
            System.Console.ReadKey();
            System.Console.WriteLine("Are you ready to play Dojo Adventures? Get your hype pants on...\n");
            System.Console.ReadKey();

            // Initiate a new Game
            Program New_Game = new Program();
            New_Game.Start_Game();
        }
    }
}