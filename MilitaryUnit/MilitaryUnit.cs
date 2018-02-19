using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit 
{
    // Program Control Class
    class MilitaryUnit 
    {
        // Objects of class types
        
        //public Helecopters cobra = new Helecopters();
        //public Tanks sherman = new Tanks();
        string V1 = "deploy vehicle";
        string V2 = "deploy vehicle";
        string V3 = "deploy vehicle";
        public string N1 = "all quiet";
        public string N2 = "all quiet";
        public string N3 = "all quiet";

        // Allows user to play the game until they are done and choose to quit
        public void Run()
        {
            bool quit;

            do
            {
                Console.Clear();
                Mission();
                DispayMainMenu();
                quit = ElicitUserInput();
            }
            while (!quit);
        }

        // Displays Mission Name
        public void Mission()
        {
            Console.WriteLine($"Mission Desert Crush");
            Console.WriteLine($"Vehicles Deployed| {V1} | {V2} | {V3} |");
            Console.WriteLine($"Engine Noise| {N1} | {N2} | {N3} |");
        }

        // Displays main menu options
        void DispayMainMenu()
        {
            Console.WriteLine("Deploy Personel, Choose Vehicle");
            Console.WriteLine(" 1) Truck");
            Console.WriteLine(" 2) Helos");
            Console.WriteLine(" 3) Tanks");
            Console.WriteLine(" 4) Exit");
        }

        // Handles main navigation from the user
        bool ElicitUserInput()
        {
            bool quit = false;
            bool isValid = false;

            do
            {
                try
                {
                    Console.Write("Please select an option:");
                    int choice = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Mission();
                    isValid = true;

                    switch (choice)
                    {
                        // Handles Main Menu selection 1 Truck
                        case 1:

                            Console.WriteLine("\nPersonel Loading into Halftrack:");
                            Trucks theTruck = new Trucks();
                            V1 = theTruck.TypeTruck("Halftrack");
                            N1 = theTruck.StartEngine("Brm brm");

                            break;

                        // Handles Main Menu selection 2 Helos
                        case 2:

                            Console.WriteLine("\nPersonel Loading into Helo:");
                            Helecopters theHelo = new Helecopters();
                            V2 = theHelo.TypeHelo("Huey");
                            N2 = theHelo.StartEngine("wop, wop, wop");
                            
                            break;


                        // Handles Main Menu selection 3 Tank
                        case 3:
                            Console.WriteLine("\nPersonel Loading into Tank:");
                            Tanks theTank = new Tanks();
                            V3 = theTank.TypeTank("Sherman");
                            N3 = theTank.StartEngine("sqeek, rrrrr, sqeek, rrrrr");

                            break;

                        // Exit case
                        case 4:
                            Console.WriteLine("\nMission Accomplished!\n");
                            Console.Write("Press enter to exit.");
                            Console.ReadLine();
                            quit = true;
                            break;

                        // Returns "please try again" for invalid selection 
                        default:
                            isValid = false;
                            Console.WriteLine("please try again.");
                            DispayMainMenu();
                            break;
                    }
                }

                catch (FormatException)
                {
                    isValid = false;
                }
            }
            while (!quit && !isValid);

            return quit;
        }

    }
}