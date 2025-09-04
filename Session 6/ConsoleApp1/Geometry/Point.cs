using System;

namespace OOInheritance.Geometry
{
    public class Point : Object
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x=0, int y=0)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"{X},{Y}";
        }
    }
}
