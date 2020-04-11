using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class TalkativeCannibal: CannibalHabbits
    {
        
        public override void Cook()
        {
            Console.WriteLine("Беседует с потенциальной едой");

            if (IsWeekend())
            {
                Console.WriteLine("Ест");
            }
            else
            {
                Console.WriteLine("Дарит");
            }
        }


        bool IsWeekend()
        {
            string answer = getUserInput();
            if (answer.ToLower().StartsWith("y")){
                return true;
            }
            else return false;
        }

        string getUserInput()
        {
            String answer = " ";
            Console.WriteLine("Выходной день? (y/n)");
            try
            {
                answer = Console.ReadLine();
            }

            catch(Exception e)
            {
                Console.WriteLine("IO ошибка при попытке прочитать ответ");
            }
            if (answer == null || answer == " ")
                return "no";
            return answer;
        }
    }
}
