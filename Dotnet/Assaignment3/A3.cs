using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assaignment5
{
    class Shapes
    {
        int area;
        int lenght;
        int breadth;
        double height;
        double Base;
        static double pi = 3.14;
        double radius;
        public void Area(int length)
        {
            area = length * length;
            Console.WriteLine("u have given only length so u want to find the area of squar");
            Console.WriteLine("Area of square is " + area);
        }
        public void Area(int length, int breadth)
        {
            area = length * breadth;
            Console.WriteLine("u have given both length and breadth so u want to find the area of rectangle");
            Console.WriteLine("Area of rectangle is " + area);
        }
        public void Area(double Base, double height)
        {
            area = Convert.ToInt32(0.5 * Base * height);
            Console.WriteLine("u have given both length and height so u want to find the area of triangle");
            Console.WriteLine("Area of triangle is " + area);
        }
        public void Area(double radius)
        {
            Console.WriteLine("Area of circle is ");
            Console.WriteLine( pi * radius * radius);
        }
    }

    internal class A3
    {
        public static void Main()
        {
            Shapes s = new Shapes();
            s.Area(2, 3);
            s.Area(2.0, 3.0);
            s.Area(2);
            s.Area(9.0d);

        }
    }

}
