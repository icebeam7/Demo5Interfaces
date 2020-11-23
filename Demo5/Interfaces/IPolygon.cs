using System;
using System.Collections.Generic;
using System.Text;

namespace Demo5.Interfaces
{
    public interface IPolygon
    {
        double SideLength { get; set; }
        double NumberOfSides { get; set; }

        double GetPerimeter();

        double GetArea();
    }
}
