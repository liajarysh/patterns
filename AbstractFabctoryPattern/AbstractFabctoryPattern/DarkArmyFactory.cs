using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabctoryPattern
{
    public class DarkArmyFactory: ArmyFactory
    {
        public DarkArmyFactory()
        {
            Console.WriteLine("Создание темной армии");
        }
        public Healer createHealer()
        {
            return new DarkPriest();
        }

        public DamageDealer createDD()
        {
            return new Assasin();
        }

        public Tank createTank()
        {
            return new Werewolf();
        }

        public SpellCaster createSpellCaster()
        {
            return new Necromancer();
        }
    }
}
