using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int guess = 0;
        int magicNumber = randomGenerator.Next(1, 11);
        Console.WriteLine("Welcome to the Random Number Generator.");
        Console.Write("");
        do{
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher!");
            }
            if (guess > magicNumber)
            {
                Console.WriteLine("Lower!");
            }
        } while (guess != magicNumber);
        
        Console.WriteLine($"You guesssed it! The magic number is {magicNumber}");
        
    }
}