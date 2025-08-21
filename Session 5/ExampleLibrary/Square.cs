using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFE.Trigonometry
{
    public class Square
    {
        private int x;
        public int X
        {
            get { return x; }
        }
        private int y;
        public int Y
        {
            get { return y; }
        }
        public int Length { get; private set; }
        public Square(int x, int y, int length)
        {
            this.x = x;
            this.y = y;
            Length = length;
        }
        public Square(int length)
        {
            Length = length;
        }

        public int getArea(bool halveIt)
        {
            int result = this.getArea();
            return result/(halveIt ? 2 : 1);
        }
        public int getArea()
        {
            return Length * Length;
        }
    }
}
