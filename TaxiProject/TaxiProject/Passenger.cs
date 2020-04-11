using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiProject
{
    class Passenger
    {
        public int currentBusStop;
        public int lastBusStop;
        public int direction; // -1 - left direction, 1 - right direction 

        public Passenger(int currentBusStop, int lastBusStop, int direction)
        {
            this.currentBusStop = currentBusStop;
            this.lastBusStop = lastBusStop;
            this.direction = direction;

        }
    }
}
