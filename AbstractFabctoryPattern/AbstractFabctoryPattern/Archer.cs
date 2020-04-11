using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabctoryPattern
{
    class Archer: DamageDealer
    {
        public Archer()
        {
            Console.WriteLine("Создан лучник");
        }
        public void Attack()
        {
            Console.WriteLine("Атакует врага, использует дистанционную атаку");
        }
    }
}
