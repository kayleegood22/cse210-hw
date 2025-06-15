using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a menu option: ");

            string input = Console.ReadLine();
            int.TryParse(input, out choice);

            if (choice == 1)
            {
                new BreathingActivity().Start();
            }
            else if (choice == 2)
            {
                new ReflectionActivity().Start();
            }
            else if (choice == 3)
            {
                new ListingActivity().Start();
            }
            else if (choice == 4)
            {
                Console.WriteLine("Goodbye!");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("That is not a valid option.");
                Thread.Sleep(1000);
            }
        }
    }
}
