using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Vehicles 
    {   
        //Method to handle StartEngine noise from mainMenu 
        public string StartEngine(string noiseToMakeWhenStarting)
        {
            Console.WriteLine($"Starting engine: {noiseToMakeWhenStarting}");
            //N1 = noiseToMakeWhenStarting;
            return noiseToMakeWhenStarting; 
        }

        // Method to pass default truckType back to console from main menu when truck type is not explicitly hardcoded
        public virtual string TypeTruck(string truckType)
        {
            Console.WriteLine("Hum V");

            return truckType;
        }
        
    }
}
