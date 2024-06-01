using System;

namespace shape
{
    public class ComparableCircle : Circle, IComparable<ComparableCircle>
    {
        public ComparableCircle() { }
        public ComparableCircle(double radius) : base(radius) { }
        public ComparableCircle(double radius, string color, bool filled) : base(radius) { }
        

        public int CompareTo(ComparableCircle other)
        {
            if (getRadius() > other.getRadius()) return 1;
            else if (getRadius() < other.getRadius()) return -1;
            else return 1;
        }
    }
}
