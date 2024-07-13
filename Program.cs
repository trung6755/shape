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
            //Shape shape = new Shape();
            //Console.WriteLine(shape);

            //Shape shape2 = new Shape("red", false);
            //Console.WriteLine(shape2);

            //Circle circle = new Circle();
            //Console.WriteLine(circle);

            //Circle circle2 = new Circle(5);
            //Console.WriteLine(circle2 + " dien tich la " + circle2.getArea() + ", chu vi la " + circle2.getPerimeter());

            //ComparableCircle[] circles = new ComparableCircle[1];
            //circles[0] = new ComparableCircle(3.6);
            
            

            //Console.WriteLine("Pre-sorted:");
            //foreach (ComparableCircle circle1 in circles)
            //{
            //    Console.WriteLine(circle);
            //}

            //Array.Sort(circles);

            //Console.WriteLine("After-sorted:");
            //foreach (ComparableCircle circle1 in circles)
            //{
            //    Console.WriteLine(circle);
            //}

            // CircleComparer Test:

            Circle[] circles1 = new Circle[3];
            circles1[0] = new Circle(3.6);
            circles1[1] = new Circle();
            circles1[2] = new Circle(3.5);

            Console.WriteLine("Pre-sorted:");
            foreach (Circle circle1 in circles1)
            {
                Console.WriteLine(circle1);
            }

            IComparer<Circle> circleComparator = new CircleComparator();
            Array.Sort(circles1, circleComparator);

            Console.WriteLine("After-sorted:");
            foreach (Circle circle1 in circles1)
            {
                Console.WriteLine(circle1);
            }

            Square square = new Square(5, "red");
            Console.WriteLine(square);
            square.HowToColor();
            Console.WriteLine(square);

        }
    }
}
