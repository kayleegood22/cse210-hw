using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Fractions Program");
        Fraction f1 = new Fraction();
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
    }
}