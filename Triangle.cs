using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab1
{
    public class Triangle : Rectangle, IFigure
    {
        public Triangle(int x1, int x2, int y1, int y2) : base(x1, x2, y1, y2)
        {

        }

        public override void Draw()
        {
            Console.WriteLine($"Triangle({X1},{X2},{Y1},{Y2})");
        }
    }
}
