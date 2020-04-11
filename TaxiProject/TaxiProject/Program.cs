using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiProject
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int busStopsN = 5;                                                           //количество остановок  
            BusStop[] busStops = new BusStop[busStopsN]; 
            for (int i = 0; i < busStopsN; ++i)
            {
                busStops[i] = new BusStop(i);                                             //иницилизация остановок в массиве
            }

            Random rnd = new Random();
            for (int i = 0; i < busStopsN; ++i)
            {
                int passengersN = rnd.Next(0, 12);                                         //случайно задается количество людей на остановке
                for (int j = 0; j < passengersN; ++j)
                {
                    int lastStop = rnd.Next(0, busStopsN - 1);                             //случайно задается конечная остановка для пассажира
                    if (lastStop == i)                                                     //если полученная конечная остановка совпадает с начальной, конечная остановка изменяется на несовпадающую
                        lastStop = i==0? busStopsN - 1: busStopsN - lastStop;
                    int direction = i < lastStop ? 1: -1;                                  //по начальной и конечной остановке определяется направление
                    busStops[i].addPassengerToQueue(new Passenger(i, lastStop, direction));//пассажир добавляется на остановку
                }
            }

            int[] busRoute = { 0, 1, 2, 3, 4};                                             //маршрут для автобуса
            Bus bus = new Bus(12, 1, busRoute);                                            

            int n = 2;
            while ( n-- > 0)
            {
                for (int i = 0; i < busStopsN; ++i)
                {
                    bus.makeAStop(i);                                                     //автобус делает остановку
                    int stopID = bus.route[i];                                            //определяется id остановки в соответствии с маршрутом автобуса
                    busStops[stopID].showPassengers();
                    Console.WriteLine("Вышло пассажиров " + bus.outBus(i));
                    if (bus.direction > 0)                                                 //в зависимости от направления движения автобуса просматривается одна из двух очередей на остановке
                        Console.WriteLine("Вошло пассажиров: " + bus.inBus(ref busStops[stopID].rPassengerQueue));
                    else if (bus.direction < 0)
                        Console.WriteLine("Вошло пассажиров " + bus.inBus(ref busStops[stopID].lPassengerQueue));
                    bus.showNumberOfFreePlaces();
                    Console.WriteLine(" ");
                }
                bus.reverseRoute();                                                       //маршрут инвертируется
                Console.WriteLine("Автобус доехал до конечной и повернул обратно");

            }

            Console.ReadKey();
        }
    }
}
