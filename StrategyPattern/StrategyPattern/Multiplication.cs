using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Multiplication: ICalculateBehavior
    {
        public float Calculate(float a, float b)
        {
            Console.WriteLine("Умножение двух чисел");
            return a * b;
        }
    }
}
