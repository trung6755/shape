using System;

namespace shape
{
    public class Circle
    {
        private double radius = 1;

        public Circle()
        {

        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double getRadius()
        {
            return radius;
        }

        public double getArea()
        {
            return radius * radius * Math.PI;
        }

        public double getPerimeter()
        {
            return radius * 2 * Math.PI;
        }

        public override String ToString()
        {
            return "A Circle with radius = "
                    +getRadius()
                    + ", which is a subclass of "
                    +base.ToString();

        }
    }
}
