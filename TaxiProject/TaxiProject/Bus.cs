using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiProject
{
    class Bus
    {
        public int capacity;
        public int direction; //важное
        int currentStop;
        public int[] route;
        public List<Passenger> passengers = new List<Passenger>();


        public Bus(int capacity, int direction, int[] busStops)
        {
            this.capacity = capacity;
            this.direction = direction;
            route = busStops;
            currentStop = route[0];

        }



        public int inBus(ref Queue<Passenger> newPassengers)
        {
            int nPassengersIn = 0;
            while (checkCapacity() && newPassengers.Count() != 0)
            {
                passengers.Add(newPassengers.Dequeue());
                nPassengersIn += 1;
            }
            return nPassengersIn;
        }

        public void makeAStop(int i)
        {

            Console.WriteLine("Автобус остановился на остановке номер " + route[i]);

        }

        public int outBus(int stopID)
        {
            int nPassengersOut = 0;
            List<Passenger> newPassengersList = new List<Passenger>();

            for (int i = 0; i < passengers.Count() ; ++i)
            {
                if (passengers[i].lastBusStop == stopID)
                {
                    nPassengersOut += 1;
                }
                else
                    newPassengersList.Add(passengers[i]);
            }
            passengers.Clear();
            passengers = newPassengersList;
            return nPassengersOut;
        }

        public void showNumberOfFreePlaces()
        {
            Console.WriteLine("Свободных мест: " + (capacity - passengers.Count()));
        }

        public bool checkCapacity()
        {
            if (capacity == passengers.Count())
            {
                Console.WriteLine("Свободных мест нет!");
                return false;
            }
            return true;
        }

        public void reverseRoute()
        {
            direction *= -1;
            Array.Reverse(route);
        }
    }
}
