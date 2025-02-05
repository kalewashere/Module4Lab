using System;

namespace Module4Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("🚀 Module 4 Lab Menu 🦁");
                Console.WriteLine("----------------------");
                Console.WriteLine("1. Launch Rocket Couontdown");
                Console.WriteLine("2. Manage Zoo Animals");
                Console.WriteLine("3. Exit");
                Console.WriteLine("\nEnter your choice (1-3)");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Black;
                        RocketCountdown.RunRocketProgram();
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case "2":
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.Black;
                        ZooAnimals.RunZooProgram();
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case "3":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Thank you for using the Module 4 Lab programs!");
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.White;
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nInvalid choice. Please enter 1, 2, or 3.");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }

                Console.WriteLine("\nPress Enter to return to the menu...");
                Console.ReadLine();
            }
        }
    }
}