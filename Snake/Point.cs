using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sum;

        public Point()
        {
        }
        public Point (int _x, int  _y, char _sum)
        {
            x = _x;
            y = _y;
            sum = _sum;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sum);
        }
    }
}
