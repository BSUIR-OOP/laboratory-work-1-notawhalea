using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle re = new Rectangle(11, -10, 10, 10);

            Rhomb rh = new Rhomb(2, 1, 1, 1);

            Triangle tr = new Triangle(4, 4, 4, 4);

            ListFigures list = new ListFigures();

            list.AddFigure(re);
            list.AddFigure(new Rhomb(10, 10, 10, 10));
            list.AddFigure(tr);
            list.AddFigure(new Square(5, 10, 5, 10));
            list.AddFigure(new Circle(5, 5, 5));
            list.AddFigure(new Ellipse(10, 10, 10, 10));

            list.PrintFigures();
            
            Console.ReadKey();
        }
    }
}
