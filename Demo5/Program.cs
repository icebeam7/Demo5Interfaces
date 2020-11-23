using System;
using Demo5.Classes;
using Demo5.Interfaces;

namespace Demo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            square.NumberOfSides = 4;
            square.SideLength = 20;

            square.DisplayInfo();
            square.ShowShape();

            //IPolygon polygon = new IPolygon(); // an interface can-t be instantiated
            IPolygon polygon = new Triangle();
            polygon.NumberOfSides = 3;
            polygon.SideLength = 6;
            Console.WriteLine("Perimeter: " + polygon.GetPerimeter());
            Console.WriteLine("Area: " + polygon.GetArea());

            Console.ReadKey();




        }
    }
}
