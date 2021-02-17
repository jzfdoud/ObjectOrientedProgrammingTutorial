using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingTutorial
{
    class Rectangle : Quad
    {

        public override string Print() 
        /*"new" tells system we are purposely overidding a method with the same name from the inherited class
         to perform the "new" defined method */
        {
            return "Rectangle";
        }

        public int Area()
        {
            return Side1 * Side2;
        }
        public Rectangle() { }

        public Rectangle(int s1, int s2) : base(s1, s2, s1, s2)
        {

        }
    }
}
