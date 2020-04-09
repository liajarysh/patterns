using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Division: ICalculateBehavior
    {
        public float Calculate(float a, float b)
        {
            float c = 0;
            Console.WriteLine("Деление двух чисел");
            try
            {
                c =  a/b;
            }

            catch(Exception e)
            {
                Console.WriteLine("Деление на 0");
            }
            return c;
        }
    }
}
