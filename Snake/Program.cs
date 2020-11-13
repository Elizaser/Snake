using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLine lineUp = new HorizontalLine(0, 117, 0, '+');
            lineUp.Drow();

            HorizontalLine lineDown = new HorizontalLine(0, 117, 29, '+');
            lineDown.Drow();
            
            VerticalLine lineLeft = new VerticalLine(0, 0, 29, '+');
            lineLeft.Drow();


            VerticalLine lineRight = new VerticalLine(118, 0, 29, '+');
            lineRight.Drow();

            Point p = new Point(4, 5, '*');

            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);

            Console.ReadLine();
        }


    }
}
