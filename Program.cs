using System;

namespace terminal_rpg
{
    class Program
    {

        public void Start_Game()
        {
            System.Console.WriteLine("Welcome to Dojo Adventures!");
            System.Console.WriteLine("Are you ready to play Dojo Adventures? Get hyped...");
        }

        // Main method invoked upon running program
        static void Main(string[] args)
        {
            // Create new player of class Human
            Human me = new Human("Maki");
            me.Health = 200;

            // Create new heroes
            Scribe Steve = new Scribe("Steve");
            Wizard Wanda = new Wizard("Wanda");
            Ninja Nick = new Ninja("Nick");
            Samurai Sam = new Samurai("Sam");

            // Create new enemies
            Zombie Zeek = new Zombie("Zeek");
            GiantBaby Timmy = new GiantBaby("Timmy");
            Spider Slink = new Spider("Slink");
            Goblin Goblix = new Goblin("Goblix");

            // Show stats of players at the beginning of the game
            System.Console.WriteLine("\n\n============================== Before Attacking ===============================\n");
            System.Console.WriteLine("~ ALL PLAYERS ~\n");
            System.Console.WriteLine("Player 1: {0}", me.ShowStatus());

            // Show stats of heroes at the beginning of the game
            System.Console.WriteLine("\n~ ALL HEROES ~\n");
            System.Console.WriteLine("  Hero 1: {0}", Steve.ShowStatus());
            System.Console.WriteLine("  Hero 2: {0}", Wanda.ShowStatus());
            System.Console.WriteLine("  Hero 3: {0}", Nick.ShowStatus());
            System.Console.WriteLine("  Hero 4: {0}", Sam.ShowStatus());

            // Show stats of enemies at the beginning of the game
            System.Console.WriteLine("\n~ ALL ENEMIES ~\n");
            System.Console.WriteLine(" Enemy 1: {0}", Zeek.ShowStatus());
            System.Console.WriteLine(" Enemy 2: {0}", Timmy.ShowStatus());
            System.Console.WriteLine(" Enemy 3: {0}", Slink.ShowStatus());
            System.Console.WriteLine(" Enemy 4: {0}", Goblix.ShowStatus());

            // Attack round
            System.Console.WriteLine("\n=============================== While Attacking ===============================\n");
            System.Console.WriteLine("1. Wanda fireballs me.");
            Wanda.Fireball(me);
            System.Console.WriteLine("2. I attack Steve.");
            me.Attack(Steve);
            System.Console.WriteLine("3. Steve stabs Wanda with his quill.");
            Steve.Quill_Stab(Wanda);
            System.Console.WriteLine("4. Sam death blows Wanda. (Suck it Wanda!)");
            Sam.Death_Blow(Wanda);
            System.Console.WriteLine("5. Nick steals from Sam.");
            Nick.Steal(Sam);

            // Show stats of players after attacking
            System.Console.WriteLine("\n=============================== After Attacking ===============================\n");
            System.Console.WriteLine("~ ALL PLAYERS ~\n");
            System.Console.WriteLine("Player 1: {0}", me.ShowStatus());

            // Show stats of heroes after attacking
            System.Console.WriteLine("\n~ ALL HEROES ~\n");
            System.Console.WriteLine("  Hero 1: {0}", Steve.ShowStatus());
            System.Console.WriteLine("  Hero 2: {0}", Wanda.ShowStatus());
            System.Console.WriteLine("  Hero 3: {0}", Nick.ShowStatus());
            System.Console.WriteLine("  Hero 4: {0}", Sam.ShowStatus());

            // Show stats of enemies after attacking
            System.Console.WriteLine("\n~ ALL ENEMIES ~\n");
            System.Console.WriteLine(" Enemy 1: {0}", Zeek.ShowStatus());
            System.Console.WriteLine(" Enemy 2: {0}", Timmy.ShowStatus());
            System.Console.WriteLine(" Enemy 3: {0}", Slink.ShowStatus());
            System.Console.WriteLine(" Enemy 4: {0}", Goblix.ShowStatus());

            // Heal round
            System.Console.WriteLine("\n================================ While Healing ================================\n");
            System.Console.WriteLine("1. Wanda uses heal on herself.");
            Wanda.Heal();
            System.Console.WriteLine("2. Sam uses meditate on himself.");
            Sam.Meditate();

            // Show stats of players after healing
            System.Console.WriteLine("\n================================ After Healing ================================\n");
            System.Console.WriteLine("~ ALL PLAYERS ~\n");
            System.Console.WriteLine("Player 1: {0}", me.ShowStatus());

            // Show stats of heroes after healing
            System.Console.WriteLine("\n~ ALL HEROES ~\n");
            System.Console.WriteLine("  Hero 1: {0}", Steve.ShowStatus());
            System.Console.WriteLine("  Hero 2: {0}", Wanda.ShowStatus());
            System.Console.WriteLine("  Hero 3: {0}", Nick.ShowStatus());
            System.Console.WriteLine("  Hero 4: {0}", Sam.ShowStatus());

            System.Console.WriteLine("\n");

            // Testing
            Actions actions = new Actions();
            Program New_Game = new Program();
            New_Game.Start_Game();
            Samurai.How_Many();
            Human Jeff = new Human("Jeff");
            Zombie zeek1 = new Zombie("zeek");
            Zombie zeek2 = new Zombie("zeek");
            Zombie zeek3 = new Zombie("zeek");
            Grenade grenade = new Grenade();
            Heal_Potion heal = new Heal_Potion();
            Enrage enrage = new Enrage();
            grenade.Add();
            grenade.Add();
            grenade.Add();
            heal.Add();
            grenade.How_Many();
            heal.How_Many();
            enrage.How_Many();
            grenade.Use(zeek1);
            System.Console.WriteLine(zeek1.Health);
            grenade.How_Many();
            enrage.Use(Jeff);
        }
    }
}