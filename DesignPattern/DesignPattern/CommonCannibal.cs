﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class CommonCannibal: CannibalHabbits
    {
        public override void chat() { }
        public override void cook()
        {
            Console.WriteLine("Сварил жертву");
        }
    }
}
