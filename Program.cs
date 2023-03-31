using System.Xml.Linq;

namespace HeavenlyVisions
{
    internal class Program
    {
        private static string input;
        private static List<Tour> tours = new List<Tour>();

        static void Main(string[] args)
        {     
            //Open the main menu
            MainMenu();
        }

        static void MainMenu() //asks the user what they want to do
        {
            //Declaring user input variables
            string name;
            string date;
            string time;
            string loc;
            string desc;

            //displaying menus
            Console.Clear();
            Console.WriteLine("Heavenly Visions Tour Manager\n\nWhat would you like to do?\n");
            Console.WriteLine("View Tours [1]\nAdd New Tour[2]\nExit[3]");

            input = Console.ReadLine();
            switch (input)
            {
                case "1": //view tours
                    ViewTours();
                    break;

                case "2": //add tour
                    Console.Clear();
                    
                    Console.WriteLine("Heavenly Visions Tour Manager\n\nPlease Enter a name:\n");
                    name = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("Heavenly Visions Tour Manager\n\nPlease Enter a date:\n");
                    date = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("Heavenly Visions Tour Manager\n\nPlease Enter a time:\n");
                    time = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("Heavenly Visions Tour Manager\n\nPlease Enter a location:\n");
                    loc = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("Heavenly Visions Tour Manager\n\nPlease Enter a description:\n");
                    desc = Console.ReadLine();
                    Console.Clear();

                    tours.Add(new Tour(name, date, time, loc, desc));
                    break;

                case "3": //exit
                    Environment.Exit(0);
                    break;

                default: //bad input
                    Console.WriteLine("Incorrect Input!\nPlease try again!\n\n> ");
                    Console.ReadLine();
                    break;
            }
            MainMenu();
        }

        static void ViewTours() //view all tours
        {
            Console.Clear();
            Console.WriteLine("Heavenly Visions Tour Manager\n\n");
            foreach (Tour tour in tours) 
            {
                Console.WriteLine("Name: " + tour.getName() + "\n\tLocation: " + tour.getLocation() + "\n\tDate: " + tour.getDate()
                + "\n\tTime: " + tour.getTime() + "\n\tDescription: " + tour.getDescription() + "Customers: \n");
                foreach (Customer customer in tour.getCustomers()) 
                {
                    Console.WriteLine("\t\tName: " + customer.getName() + "\n\t\t\tPhone: " + customer.getPhone() + "\n\t\t\tEmail: "
                    + customer.getEmail() + "\n\t\t\tNotes: " + customer.getNotes() + "\n");
                }
                   
            }
            Console.WriteLine("\nPress any key to return.");
            Console.ReadLine();
        }
    }
}