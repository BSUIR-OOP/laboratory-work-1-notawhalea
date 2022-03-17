using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab1
{
    public class Ellipse : Circle
    {
        private int Width { get; set; }
        private int Height { get; set; } 
        public Ellipse(int x,int y,int height,int width):base(x,y,height)
        {
            Width = width;
            Height = height;
        }

        public override void Draw()
        {
            Console.WriteLine($"Ellipse({X},{Y},{Height},{Width})");
        }
    }
}
