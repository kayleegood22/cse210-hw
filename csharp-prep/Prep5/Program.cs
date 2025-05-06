using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        string text = DisplayWelcome();
        int number = PromptUserNumber();
        string result = DisplayResult(PromptUserName(), SquareNumber(number));
        Console.WriteLine(result);

    }
    static string DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
        string text = Console.ReadLine();
        return text;
    }
    static int PromptUserNumber() 
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string text = Console.ReadLine();
        return text;

    }
    static int SquareNumber(int integer)
    {
        int squared = integer * integer;
        return squared; 
    }
    static string DisplayResult(string name, int integer)
    {
        Console.Write($"{name}, the square of your number is {integer}");
        string text = Console.ReadLine();
        return text;
    }
}