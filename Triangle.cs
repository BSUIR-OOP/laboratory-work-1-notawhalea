using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab1_Remake
{
    public class Triangle : IFigure
    {
        protected int X1 { get; set; }
        protected int X2 { get; set; }
        protected int X3 { get; set; }
        protected int Y1 { get; set; }
        protected int Y2 { get; set; }
        protected int Y3 { get; set; }


        public Triangle(int x1, int x2, int x3, int y1, int y2, int y3)
        {
            X1 = x1; X2 = x2; Y1 = y1; Y2 = y2; X3 = x3; Y3 = y3;

            if (X1 < 0 || X2 <= 0 || Y1 <= 0 || Y2 <= 0 || X3 <= x3 || Y3 <= y3)
            {
                X1 = Math.Abs(X1);
                X2 = Math.Abs(X2);
                Y1 = Math.Abs(Y1);
                Y2 = Math.Abs(Y2);
                X3 = Math.Abs(X3);
                Y3 = Math.Abs(Y3);
            }

            if (X1 > X2)
                (X1, X2) = SwapPoints(X1, X2);

            if (X2 > X3)
                (X1, X2) = SwapPoints(X1, X2);

            if (Y1 > Y2)
                (Y1, Y2) = SwapPoints(Y1, Y2);

            if (Y2 > Y3)
                (Y2, Y3) = SwapPoints(Y2, Y3);

        }

        protected (int, int) SwapPoints(int x1, int x2)
        {
            (x1, x2) = (x2, x1);
            return (x1, x2);
        }

        public void Draw()
        {
            Console.WriteLine($"Triangle({X1},{X2},{X3},{Y1},{Y2},{Y3})");
        }

        public double GetSquare()
        {
            return 0.5 * Math.Abs((X2 - X1) * (Y3 - Y1) - (X3 - X1) * (Y2 - Y1));
        }
    }
}
