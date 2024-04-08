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
            circle2.getArea();
            circle2.getPerimeter();
            
        }
    }
}
