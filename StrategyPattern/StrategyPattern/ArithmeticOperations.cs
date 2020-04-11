using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class ArithmeticOperations
    {
        ICalculateBehavior calculateBehavior;

        public float Calculate(float a, float b)
        {
            return calculateBehavior.Calculate(a, b);
        }

        public void SetCalculateBehavior(ICalculateBehavior calcBehavior)
        {
            this.calculateBehavior = calcBehavior;
        }
    }

}
