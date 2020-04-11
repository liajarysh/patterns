using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public abstract class CannibalHabbits
    {
        public void Habbits()
        {
            catchVictim();
            Cook();
            Eat();
            Sleep();
        }

        public void catchVictim()
        {
            Console.WriteLine("Поймал жертву");
        }

        public void Eat()
        {
            Console.WriteLine("Поел");
        }

        public void Sleep()
        {
            Console.WriteLine("Отошел ко сну");
        }

        public abstract void Cook();

    }
}
