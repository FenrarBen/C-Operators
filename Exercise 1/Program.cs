using System;

namespace Exercise_1
{
    class Program
    {
        static double AreaOfCircle(double r)
        {
            double area = r * r * 3.14159;

            return area;
        }

        static void Main(string[] args)
        {
            int x = 17;
            int y = 4;

            int quotient = x / y;
            int remainder = x % y;

            Console.WriteLine($"{x}/{y} is {quotient} remainder {remainder}");

            Console.WriteLine("Enter a radius value: ");
            double radius = double.Parse(Console.ReadLine());
            double area = AreaOfCircle(radius);
            Console.WriteLine($"Your area is: {area}");

        }
    }
}
