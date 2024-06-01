using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            Console.WriteLine(shape);

            Shape shape2 = new Shape("red", false);
            Console.WriteLine(shape2);

            Circle circle = new Circle();
            Console.WriteLine(circle);

            Circle circle2 = new Circle(5);
            Console.WriteLine(circle2 + " dien tich la " + circle2.getArea() + ", chu vi la " + circle2.getPerimeter());

            ComparableCircle[] circles = new ComparableCircle[1];
            circles[0] = new ComparableCircle(3.6);
            
            

            Console.WriteLine("Pre-sorted:");
            foreach (ComparableCircle circle1 in circles)
            {
                Console.WriteLine(circle);
            }

            Array.Sort(circles);

            Console.WriteLine("After-sorted:");
            foreach (ComparableCircle circle1 in circles)
            {
                Console.WriteLine(circle);
            }



        }
    }
}
