using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiProject
{
    class BusStop
    {
        public int stopId;
        public Queue<Passenger> rPassengerQueue = new Queue<Passenger>();
        public Queue<Passenger> lPassengerQueue = new Queue<Passenger>();


        public BusStop(int stopId)
        {
            this.stopId = stopId;
        }

        public void addPassengerToQueue(Passenger passenger)
        {
            if (passenger.direction > 0)
                rPassengerQueue.Enqueue(passenger);
            else if (passenger.direction < 0)
                lPassengerQueue.Enqueue(passenger);
        }
        public int countPassengersAtStop()
        {
            return (rPassengerQueue.Count() + lPassengerQueue.Count());
        }

        public void showPassengers()
        {
            Console.WriteLine("Пассажиров по правому направлению: " + rPassengerQueue.Count());
            Console.WriteLine("Пассажиров по левому направлению: " + lPassengerQueue.Count());
            Console.WriteLine("Пассажиров на остановке всего: " + countPassengersAtStop());
        }

    }
}
