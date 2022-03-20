﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab1_Remake
{
    class ListFigures
    {
        List<IFigure> figures;

        public ListFigures()
        {
            figures = new List<IFigure>();
        }

        public void AddFigure(IFigure figure)
        {
            figures.Add(figure);
        }

        public void PrintFigures()
        {
            foreach (var item in figures)
            {
                item.Draw();
            }
        }
    }
}
