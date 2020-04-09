using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public interface ICalculateBehavior
    {
        float Calculate(float a, float b);
    }
}
