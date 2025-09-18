using System.Security.AccessControl;

namespace Geometry {
    public class Rectangle {
        private string name = "Rufus";
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Rectangle(int xCoord, int yCoord, int width, int height) {
            X = xCoord;
            Y = yCoord;
            Width = width;
            Height = height;
        }
        public Rectangle(int rectWidth, int rectHeight) {
            X = 0;
            Y = 0;
            Width = rectWidth;
            Height = rectHeight;
        }
        public void Move(int Dx, int Dy) {
            X += Dx;
            Y += Dy;
        }
        public int CalculateArea() {
            return Width * Height;
        }
    }

    public class Square : Rectangle {
        public Square(int length) : base(length, length) { }
    }

    public class Cat {
        private DateTime LastFeeding;
        private List<string> StomachContents = new List<string>();

        public void Feed(string food) {
            LastFeeding = DateTime.Now;
            StomachContents.Add(food);
        }

        public TimeSpan HowLongNotEaten() {
            return DateTime.Now - LastFeeding;
        }
        public bool IsComplaining() {
            return (HowLongNotEaten() > new TimeSpan(0, 0, 0, 0, 50));
        }
    }
}