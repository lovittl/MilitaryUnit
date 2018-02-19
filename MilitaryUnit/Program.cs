using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Splash screen explaining a background on the game
            Console.WriteLine("** WELCOME TO Military Unit! **\n");
            Console.WriteLine("Go on Missions, Deploy Personell, Move Vehicles, Shoot Weapons. \n");
            Console.WriteLine("This is a Classroom Exercise to demonstrate understanding" +
                " of Inheritance.\n");
                        Console.WriteLine("Hit enter to continue.");
            Console.ReadLine();

            //Creates an instance of the MilitaryUnit class
            MilitaryUnit MUnit = new MilitaryUnit();
            MUnit.Run();
        }
    }
}
