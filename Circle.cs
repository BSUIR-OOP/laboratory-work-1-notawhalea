using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab1
{
    public class Circle : IFigure
    {
        protected int X { get; set; }
        protected int Y { get; set; }
        private int R { get; set; }

        public Circle(int x, int y, int R)
        {
            X = x; Y = y; this.R = R;
        }
        virtual public void Draw()
        {
            Console.WriteLine($"Circle({X},{Y},{R})");
        }

        public double GetSquare()
        {
            throw new NotImplementedException();
        }
    }
}
