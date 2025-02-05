using System;

namespace Module4Lab
{
    class ZooAnimals
    {
        public static void RunZooProgram()
        {
            Console.WriteLine("Welcome to the Zoo Animals Program!");
            Console.WriteLine("Let's create a list of animals in our zoo.\n");

            // this code retrieves the number of animals 
            Console.WriteLine("How many animals would you like to add?");
            int numberOfAnimals;
            while (!int.TryParse(Console.ReadLine(), out numberOfAnimals) || numberOfAnimals <= 0)
            {
                Console.Write("Please enter a valid number greater than 0: ");
            }

            // code to create an array to store animal names
            string[] animals = new string[numberOfAnimals];

            // get animal name from user 
            for (int i = 0; i < numberOfAnimals; i++)
            {
                Console.Write($"\nEnter name for animal #{i + 1}: ");
                string animalName = Console.ReadLine();

                // make sure user actaully entered something
                while (string.IsNullOrWhiteSpace(animalName))
                {
                    Console.Write("Name cannot be empty. Please enter a name: ");
                    animalName = Console.ReadLine();
                }

                animals[i] = animalName;
            }
            // display all animals 
            Console.WriteLine("\nHere are all the animals in your zoo: ");
            Console.WriteLine("------------------------------------");

            int count = 1;
            foreach (string animal in animals)
            {
                Console.WriteLine($"{count}. {animal}");
                count++;
            }

            Console.WriteLine("\nThank you for using the Zoo Animals Program!");
        }
    }
}