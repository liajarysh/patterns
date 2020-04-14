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
            chat();
            cook();
            eat();
            sleep();
        }

        public void catchVictim()
        {
            Console.WriteLine("Поймал жертву");
        }

        public void eat()
        {
            Console.WriteLine("Поел");
        }

        public void sleep()
        {
            Console.WriteLine("Отошел ко сну");
        }

        public virtual void chat() { }

        public abstract void cook();

    }
}
