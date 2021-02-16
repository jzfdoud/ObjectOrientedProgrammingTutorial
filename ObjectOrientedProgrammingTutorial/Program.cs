using System;

namespace ObjectOrientedProgrammingTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // With this demonstration we practiced inheritance with the Quadrilateral example


            var rect1 = new Rectangle(5,7);
            Console.WriteLine($" Perimeter of rect1: {rect1.Perimeter()}");
            Console.WriteLine($" Area of rect1: {rect1.Area()}");

            var sqr1 = new Square(7);
            Console.WriteLine($" Perimeter of sqr1: {sqr1.Perimeter()}");
            Console.WriteLine($" Area of sqr1: {sqr1.Area()}");
        }
    }
}
