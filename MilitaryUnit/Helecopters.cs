using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Helecopters : Vehicles
    {
        // Method to pass HeloType back to console from menu
        public string TypeHelo(string heloType)
        {
            Console.WriteLine($"{heloType}");
            return heloType;
        }
    }
}
