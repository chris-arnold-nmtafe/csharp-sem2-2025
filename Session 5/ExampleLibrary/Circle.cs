namespace TAFE.Trigonometry
{
    public class Circle
    {
        private int x;
        public int X { 
            get { return x; } 
        }
        private int y;
        public int Y
        {
            get { return y; }
        }
        private double radius;

        public Circle(int x, int y, double radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public double GetArea()
        {
            return radius * radius * Math.PI;
        }
        public void MoveTo(int xPos,int yPos)
        {
            x = xPos;
            y = yPos;
        }
        public bool intersects(Circle other)
        {
            double distanceToOther=Math.Sqrt(Math.Pow(other.x - x,2) + Math.Pow(other.y - y, 2));
            return distanceToOther < (radius+other.radius);
        }
    }
}
