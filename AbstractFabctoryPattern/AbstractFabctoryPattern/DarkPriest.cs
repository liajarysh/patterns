using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabctoryPattern
{
    class DarkPriest: Healer
    {
        public DarkPriest()
        {
            Console.WriteLine("Создан темный жрец");
        }
        public void castHeal()
        {
            Console.WriteLine("Исцеляет соратников, накладывает негативные эффекты на противника");
        }
    }
}
