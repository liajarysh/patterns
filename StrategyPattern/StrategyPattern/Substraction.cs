using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Substraction: ICalculateBehavior
    {
        public float Calculate(float a, float b)
        {
            Console.WriteLine("Вычитание двух чисел");
            return a - b;
        }
    }
}
