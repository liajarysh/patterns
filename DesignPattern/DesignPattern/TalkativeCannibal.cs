using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class TalkativeCannibal: CannibalHabbits
    {
        
         public override void chat()
        {
            Console.WriteLine("Беседует с потенциальной едой");

        }
        public override void cook()
        {

            if (isWeekend())
            {
                Console.WriteLine("Сварил жертву");
            }
            else
            {
                Console.WriteLine("Пожарил жертву");
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
