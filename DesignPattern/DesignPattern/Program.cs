using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main()
        {
            CommonCannibal Tommy = new CommonCannibal();
            Tommy.Habbits();

            TalkativeCannibal Rick = new TalkativeCannibal();
            Rick.Habbits();

            Console.ReadKey();
        }
    }
}
