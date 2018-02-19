using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Trucks : Vehicles
    {
        // Method to pass truckType back to console from menu
        public override string TypeTruck(string truckType)
        {
            //string truck1 = "halftrack";
            Console.WriteLine($"{truckType}");
            return truckType;
        }
    }
}
