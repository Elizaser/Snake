using System;
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
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sum = '*';
            p1.Draw();

            //int x1 = 1, y1 = 3;
            //char sum1 = '*';
            Point p2 = new Point();
            p2.x = 4;
            p2.y = 5;
            p2.sum = '#';
            p2.Draw();

            //int x2 = 4, y2 = 5;
            //char sum2 = '#';

            Console.ReadLine();
        }


    }
}
