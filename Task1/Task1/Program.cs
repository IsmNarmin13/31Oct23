using System;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

class Program
{
    static double Square(double number)
    {
        return number * number;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        double input = double.Parse(Console.ReadLine());

        double result = Square(input);

        Console.WriteLine($"The square of {input} is {result}");
    }
}