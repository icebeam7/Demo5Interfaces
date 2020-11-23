using System;
using System.Collections.Generic;
using System.Text;
using Demo5.Interfaces;

namespace Demo5.Classes
{
    public class Square : ICalculation, IDraw
    {
        public double SideLength { get; set; }

        public double NumberOfSides { get; set; }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        public double GetArea()
        {
            return SideLength * SideLength;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Perimeter: " + GetPerimeter());
            Console.WriteLine("Area: " + GetArea());
        }

        public void Print()
        {
            Console.WriteLine("This is a square");
        }

        public void ShowShape()
        {
            Console.Write(' ');
            Console.WriteLine(new String('-', (int)SideLength - 2));

            for (int i = 0; i < ((int)SideLength - 2) / 2; i++)
            {
                Console.Write("|");
                Console.Write(new String(' ', (int)SideLength - 2));
                Console.WriteLine("|");
            }

            Console.Write(' ');
            Console.WriteLine(new String('-', (int)SideLength - 2));
        }


    }
}
