using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabctoryPattern
{
    class Assasin: DamageDealer
    {
        public Assasin()
        {
            Console.WriteLine("Создан убийца");
        }
        public void Attack()
        {
            Console.WriteLine("Аттакует вражескую цель, использует ближнюю атаку");
        }
    }
}
