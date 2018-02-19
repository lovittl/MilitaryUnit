using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Tanks : Vehicles
    {
        // Method to pass tankType back to console from menu
        public string TypeTank(string tankType)
        {
            Console.WriteLine($"{tankType}");
            return tankType;
        }
    }
}
