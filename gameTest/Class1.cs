using Xunit;
using terminal_rpg;

namespace gameTest
{
    public class Class1
    {
        Human testplayer = new Human("Test");
        Wizard testWizard = new Wizard("Test");
        [Fact]
        public void HumanActionTest()
        {
            Assert.Equal("Attack", testplayer.Actions[1]);
        }

        [Fact]
        public void HumanInventoryTest()
        {
            Assert.Equal(3, testplayer.Inventory["Heal_Potion"]);
        }

        [Fact]
        public void HumanNameTest()
        {
            Assert.Equal("Test", testplayer.Name);
        }

        [Fact]
        public void AttackTest()
        {
            Assert.Equal(100, testplayer.Health);
            Assert.Equal(50, testWizard.Health);
            testplayer.Attack(testWizard);
            Assert.Equal(35, testWizard.Health);
        }

        [Fact]
        public void WizardHealTest()
        {
            testWizard.Heal();
            Assert.Equal(175, testWizard.Health);
        }

        [Fact]
        public void WizardFireballTest()
        {
            testWizard.Fireball(testplayer);
            Assert.NotEqual(2, testplayer.Health);
        }
    }
}