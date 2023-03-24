namespace HeavenlyVisions
{
    internal class Program
    {
        private static string input;
        private static Tour tours;

        static void Main(string[] args)
        {
            //load tour profile

            tours.append(tour);

            //Open the main menu
            MainMenu();
        }

        static void MainMenu() //asks the user what they want to do
        {
            Console.Clear();
            Console.WriteLine("Heavenly Visions Tour Manager\n\nWhat would you like to do?\n");
            Console.WriteLine("View Tours [1]\nAdd New Tour[2]\nExit[3]");

            input = Console.ReadLine();
            switch (input)
            {
                case "1": //view tours
                    //display tours
                    break;

                case "2": //add tour
                    Console.Clear();
                    Console.WriteLine("Heavenly Visions Tour Manager\n\nPlease Enter a name:\n");
                    tours.Append(new Tour());
                    break;

                case "3": //exit
                    Environment.Exit(0);
                    break;

                default: //bad input
                    Console.WriteLine("Incorrect Input!\nPlease try again!\n\n> ");
                    Console.ReadLine();
                    MainMenu();
                    break;
            }
        }

        static void ViewTours() //view all tours
        {

        }
    }
}