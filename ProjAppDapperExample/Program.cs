using ProjAppDapperExample.Service;
using System;

namespace ProjAppDapperExample
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Airport airport = new Airport()
            {
                City = "Matão",
                Code = "Mat",
                Continent = "Am. Sul",
                Country = "Brasil"
            };


            new AirportService().Add(airport);

            foreach(var item in new AirportService().GetAll())
            {
                Console.WriteLine(item);
            }

        }
    }
}
