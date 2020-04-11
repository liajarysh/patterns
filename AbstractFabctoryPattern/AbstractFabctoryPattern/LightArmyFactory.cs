using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabctoryPattern
{
    public class LightArmyFactory:ArmyFactory
    {
        public LightArmyFactory()
        {
            Console.WriteLine("Создание светлой армии");
        }
        public Healer createHealer()
        {
            return new Priest();
        }

        public DamageDealer createDD()
        {
            return new Archer();
        }

        public Tank createTank()
        {
            return new Warrior();
        }

        public SpellCaster createSpellCaster()
        {
            return new Sorcerer();
        }
    }
}
