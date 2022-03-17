using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab1
{
    public class Rectangle : IFigure
    {
        protected int X1 { get; set; }
        protected int X2 { get; set; }
        protected int Y1 { get; set; }
        protected int Y2 { get; set; }

        public Rectangle(int x1, int x2, int y1, int y2)
        {
            if (x1 < 0 || x2 <= 0 || y1 <= 0 || y2 <= 0)
            {
                x1 = Math.Abs(x1);
                x2 = Math.Abs(x2);
                y1 = Math.Abs(y1);
                y2 = Math.Abs(y2);
            }

            int temp;
            
            if (x1 > x2)
            {
                temp = x1;
                x1 = x2;
                x2 = temp;
            }
            
            if (y1 > y2)
            {
                temp = y1;
                y1 = y2;
                y2 = temp;
            }

            X1 = x1; X2 = x2; Y1 = y1; Y2 = y2;
        }

        public Rectangle()
        {

        }

        virtual public void Draw()
        {
            Console.WriteLine($"Rectangle({X1},{X2},{Y1},{Y2})");
        }

        public double GetSquare()
        {
            return (X2 - X1) * (Y2 - Y1);
        }
    }
}
