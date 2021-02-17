﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingTutorial
{
    class Square : Rectangle
    {

        public override string Print()
        {
            return "Square";
        }
        public Square() { }

        public Square(int s1) : base(s1,s1)
        {
            Side1 = s1;
        }
    }
}
