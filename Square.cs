using System;

namespace shape
{
    public class Square : IColor
    {
        private double length;
        private string color;
        public Square()
        {

        }

        public Square(double length, string color)
        {
            this.length = length;
            this.color = color;
        }
        public void HowToColor()
        {
            Console.Write("Choose a color to channge");
            color = Console.ReadLine();
        }

        
    }
}
