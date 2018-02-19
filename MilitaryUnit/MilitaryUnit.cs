using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class MilitaryUnit // base class
    {
        // Objects of class types
        public Personel troops = new Personel();
        public Trucks halftrack = new Trucks();
        public Helecopters cobra = new Helecopters();
        public Tanks sherman = new Tanks();


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

            Console.WriteLine($"Mission {"Desert Chrush"}");
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
                        case 1:
                            Console.WriteLine("\nPersonel Loading into Halftrack:");
                            Trucks halftrack = new Trucks();
                            //halftrack.StartEngine("Brm brm");

                            break;

                        case 2:
                            Console.WriteLine("\nPersonel Loading into Helo:");
                            break;

                        case 3:
                            Console.WriteLine("\nPersonel Loading into Tank:"); ;
                            break;

                        case 4:
                            Console.WriteLine("\nThanks for playing!\n");
                            Console.Write("Press enter to exit.");
                            Console.ReadLine();
                            quit = true;
                            break;

                        default:
                            isValid = false;
                            Console.WriteLine("please try again.");
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