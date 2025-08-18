using System;

class Program
{
    static void Main()
    {
        // Ask the user for their favorite color
        Console.Write("Enter your favorite color: ");
        string favoriteColor = Console.ReadLine();

        // Ask the user for their favorite number
        Console.Write("Enter your favorite number: ");
        string favoriteNumber = Console.ReadLine();

        // Display the result
        Console.WriteLine($"Your favorite color is {favoriteColor} and your favorite number is {favoriteNumber}.");
    }
}