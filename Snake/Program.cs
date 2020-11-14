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

            HorizontalLine lineDown = new HorizontalLine(0, 117, 28, '+');
            lineDown.Drow();
            
            VerticalLine lineLeft = new VerticalLine(0, 0, 28, '+');
            lineLeft.Drow();


            VerticalLine lineRight = new VerticalLine(118, 0, 28, '+');
            lineRight.Drow();

            Point p = new Point(4, 5, '*');

            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            while(true)
            {
                Console.CursorVisible = false;
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }




            //snake.Move();
            //Thread.Sleep(300);
            //snake.Move();
            //Thread.Sleep(300);
            //snake.Move();
            //Thread.Sleep(300);
            //snake.Move();
            //Thread.Sleep(300);
            //Thread.Sleep(300);
            //snake.Move();
            //Thread.Sleep(300);
            //snake.Move();
            //Thread.Sleep(300);
            //snake.Move();
            //Thread.Sleep(300);

            //Console.ReadLine();
        }


    }
}
