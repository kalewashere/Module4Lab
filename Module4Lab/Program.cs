using System;
using System.Threading;

namespace Module4Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rocket Countdown!");
            Console.WriteLine("Get ready for liftoff...\n");

            // First countdown using a for loop
            Console.WriteLine("Starting main engine test...");
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine($"T-{i} seconds...");
                Thread.Sleep(1000); // Pause for one second
            }
            Console.WriteLine("Main engines tested successfully!\n");

            // Second countdown using a while loop
            Console.WriteLine("Beginning final countdown!");
            int countdown = 10;
            while (countdown > 0)
            {
                Console.WriteLine($"T-{countdown} seconds...");
                Thread.Sleep(1000);
                countdown--;
            }

            // Liftoff sequence
            Console.WriteLine("\n🚀 Liftoff! We have liftoff!");
            
            // Altitude reporting using a for loop with a different increment
            for (int altitude = 0; altitude <= 50; altitude += 10)
            {
                Console.WriteLine($"Altitude: {altitude} kilometers");
                Thread.Sleep(500);
            }

            Console.WriteLine("\nMission successful! The rocket has reached its target altitude.");
        }
    }
}

/*
    Initial view - spotted double curly brackets and set breakpoints as instructed, noticed error messages as 
    debugging ran, noting incorrect referrence. Finished instructions and removed extra curly brace, which allowed program to 
    access value @ [i] as the loop ran. Was able to confirm via running the code again and reviewing output 
*/