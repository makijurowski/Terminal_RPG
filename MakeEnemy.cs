using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terminal_rpg
{
    public class MakeEnemy
    {
        public static object obj;
        public string Name { get; set; }
        public string ClassName { get; set; }

        public MakeEnemy()
        {
            string[] names = { "Carl", "Samantha", "Robocop", "Blaine", "Roblox", "Goblix", "Jimmy", "Mr. Spanx" };
            Random random = new();
            int randomChance = random.Next(1, 5);
            int randomName = random.Next(1, 10);

            switch (randomChance)
            {
                case 1:
                    Goblin goblinEnemy = new(names[randomName]);
                    obj = goblinEnemy;
                    break;
                case 2:
                    Spider spiderEnemy = new(names[randomName]);
                    obj = spiderEnemy;
                    break;
                case 3:
                    Zombie zombieEnemy = new(names[randomName]);
                    obj = zombieEnemy;
                    break;
                case 4:
                    GiantBaby giantBabyEnemy = new(names[randomName]);
                    obj = giantBabyEnemy;
                    break;
            }
        }
    }
}
