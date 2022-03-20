using System;

namespace OOP_Lab1_Remake
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle re = new Rectangle(3, 1, 2, 0);

            Rhomb rh = new Rhomb(2, 1, 1, 1);

            Triangle tr = new Triangle(5, 5, 4, 1, 2, 7);

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
