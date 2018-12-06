using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestTraining.StateTestPattern
{
    public class Circle
    {
        public Circle(float radius)
        {
            Radius = radius;
        }

        public float Radius { get; private set; }

        public void Shrink()
        {
            Radius /= 2;
        }
    }
}
