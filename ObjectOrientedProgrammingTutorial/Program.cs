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

            // Going over tenants of OOP

            Console.WriteLine($" sqr1 is a {sqr1.Print()}");

            var quad1 = new Quad(3, 4, 5, 6);
            Console.WriteLine($" Perimeter of quad1: {quad1.Perimeter()}");

            var shapes = new Quad[] { sqr1, rect1, quad1 };
            foreach(var shape in shapes)
            {
                Console.WriteLine($" shape is a {shape.Print()}");
                var rect = shape as Rectangle;
                if(rect != null)
                {
                    Console.WriteLine($"--> shape's area: {rect.Area()}");
                }
            }
        }
    }
}
