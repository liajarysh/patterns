using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabctoryPattern
{
    class Warrior: Tank
    {
        public Warrior()
        {
            Console.WriteLine("Создан войн");
        }
        public void useAggro()
        {
            Console.WriteLine("Отвлекает врагов, переключая внимание на себя. Увеличивает аттаку соратников.");
        }
    }
}
