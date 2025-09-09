using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_8
{
    public class Rectangle
    {
        public Rectangle(int width,int height) {
            this.Width = width;
            this.Height = height;
        }
        public int Height { get;private set; }
        public int Width { get; private set; }
        public int GetArea()
        {
            return Height * Width;
        }
    }
    internal class Square : Rectangle {
        public Square(int length) : base(length,length) { }
    }
}
