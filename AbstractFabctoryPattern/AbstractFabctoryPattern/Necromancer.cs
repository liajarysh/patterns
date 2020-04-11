using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabctoryPattern
{
    class Necromancer: SpellCaster
    {
        public Necromancer()
        {
            Console.WriteLine("Создан некромант");
        }
        public void castSpell()
        {
            Console.WriteLine("Использует темную магию");
        }
    }
}
