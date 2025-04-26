using System;



class Program
{
    static void Main(string[] args)
    {
        // This is a program to compute the area of a circle.
        // Get the radius of the circle from the user.
        Console.Write("Please enter the radius: ");
        string text = Console.ReadLine();
        double radius = double.Parse(text);

        // Compute the area of the circle.
        double area = Math.PI * radius * radius;

        /* Display the area for the user to see.
        */
        Console.WriteLine($"Area of the circle: {area}");
    }
}