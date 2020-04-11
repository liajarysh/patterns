using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabctoryPattern
{
    class Program
    {
        public static void Main()
        {
            ArmyFactory factory = new DarkArmyFactory();
            factory.createTank();
            factory.createHealer();
            factory.createDD();
            factory.createSpellCaster();

            factory = new LightArmyFactory();
            factory.createTank();
            factory.createHealer();
            factory.createDD();
            factory.createSpellCaster();

            Console.ReadKey();
        }
    }
}
