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
            Console.SetBufferSize(80, 80);
            Console.SetWindowSize(80, 80);
           
           
            HorizontalLine LeftLine = new HorizontalLine(0,79,0,'#');
            LeftLine.Draw();
            HorizontalLine RightLine = new HorizontalLine(0,79, 78, '#');
            RightLine.Draw();
            VerticalLine UpLine = new VerticalLine(79, 0,78, '#');
            UpLine.Draw();
            VerticalLine DownLine = new VerticalLine(0, 0, 78, '#');
            DownLine.Draw();

            Point p = new Point(4, 7, '*');
            Snake Snake = new Snake(p, 4, Direction.RIGHT);
            Snake.Draw();
            Console.ReadLine();
        }
     }
}
