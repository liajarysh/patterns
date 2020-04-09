using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Addition: ICalculateBehavior
    {
        public float Calculate(float a, float b)
        {
            Console.WriteLine("Сложение двух чисел");
            return a + b;
        }
    }
}
