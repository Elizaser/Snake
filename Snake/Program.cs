﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(2, 3 , '#');
            p2.Draw();

            HorizontalLine lineH = new HorizontalLine(5, 10, 8, '+');
            lineH.Drow();

            VerticalLine lineV = new VerticalLine(5, 8, 13, '+');
            lineV.Drow();
            

            Console.ReadLine();
        }


    }
}
