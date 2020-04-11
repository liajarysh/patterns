using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabctoryPattern
{
    class Sorcerer:SpellCaster
    {
        public Sorcerer()
        {
            Console.WriteLine("Создан волшебник");
        }
       public void castSpell()
        {
            Console.WriteLine("Использует свтелую магию");
        }
    }
}
