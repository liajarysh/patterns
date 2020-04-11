using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabctoryPattern
{
    class Priest: Healer
    {
        public Priest()
        {
            Console.WriteLine("Создан священник");
        }

        public void castHeal()
        {
            Console.WriteLine("Исцеляет соратников, накладывает положительные эффекты на группу");
        }
    }
}
