using System;
using System.Collections.Generic;
using System.Text;
using Demo5.Interfaces;

namespace Demo5.Classes
{
    public class Triangle : IPolygon
    {
        public double SideLength { get; set; }

        public double NumberOfSides { get; set; }

        double IPolygon.GetPerimeter() // full definition
        {
            return SideLength * NumberOfSides;
        }

        public double GetArea()
        {
            return (SideLength * SideLength * Math.Sqrt(3) / 4);
        }

    }
}
