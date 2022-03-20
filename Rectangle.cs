﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab1_Remake
{
    public class Rectangle : IFigure
    {
        protected int X1 { get; set; }
        protected int X2 { get; set; }
        protected int Y1 { get; set; }
        protected int Y2 { get; set; }

        public Rectangle(int x1, int x2, int y1, int y2)
        {

            X1 = x1; X2 = x2; Y1 = y1; Y2 = y2;

            if (X1 < 0 || X2 <= 0 || Y1 <= 0 || Y2 <= 0)
            {
                X1 = Math.Abs(X1);
                X2 = Math.Abs(X2);
                Y1 = Math.Abs(Y1);
                Y2 = Math.Abs(Y2);
            }

            if (X1 > X2)
                (X1, X2) = SwapPoints(X1, X2);

            if (Y1 > Y2)
                (Y1, Y2) = SwapPoints(Y1, Y2);


        }


        protected (int,int) SwapPoints(int x1,int x2)
        {
            (x1, x2) = (x2, x1);
            return (x1, x2);
        }
        
        virtual public void Draw()
        {
            Console.WriteLine($"Rectangle({X1},{X2},{Y1},{Y2})");
        }

        virtual public double GetSquare()
        {
            return (X2 - X1) * (Y2 - Y1);
        }
    }
}
