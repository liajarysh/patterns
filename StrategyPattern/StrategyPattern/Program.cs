using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите два числа и знак операции (+ - * /) через пробел");
            string[] input = Console.ReadLine().Split();
            int a = Convert.ToInt32(input[0]);
            int b = Convert.ToInt32(input[1]);
            ArithmeticOperations operation = new ArithmeticOperations();
            if (input[2] == "+")
                operation.SetCalculateBehavior(new Addition());
            else if (input[2] == "-")
                operation.SetCalculateBehavior(new Substraction());
            else if (input[2] == "*")
                operation.SetCalculateBehavior(new Multiplication());
            else if (input[2] == "/")
                operation.SetCalculateBehavior(new Division());
            else
                Console.WriteLine("Недопустимый арифметитческий знак");

            Console.WriteLine("Результат операции: " + operation.Calculate(a, b));

            Console.ReadKey();

        } 
    }
}
