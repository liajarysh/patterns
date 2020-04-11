using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabctoryPattern
{
    class Werewolf: Tank

    {
        public Werewolf()
        {
            Console.WriteLine("Создан оборотень");
        }
        public void useAggro()
        {
            Console.WriteLine("Отвлекает врагов, переключая внимание на себя. Использует устрашение против врагов.");
        }
    }
}
