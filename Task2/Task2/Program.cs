using System;

class Program 
{ 
    static double Circle(double radius, int pi)
    {
        return pi * radius * radius;
    }

    static double Rect(double length, double width)
    {
        return length * width;
    }

    static double Triang(double a, double b, double c, double r)
    {
        double p = (a + b + c) / 2;
        return p * r;
    }

    static void Main()
    {
        double circleArea = Circle(5,3);
        Console.WriteLine(circleArea);

        double rectangleArea = Rect(2, 3);
        Console.WriteLine(rectangleArea);

        double triangleArea = Triang(2,3,4,3);
        Console.WriteLine(triangleArea);
    }
}
