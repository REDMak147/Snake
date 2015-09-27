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
            /* Point p1 = new Point(1, 3, '*');
             p1.Draw();

             Point p2 = new Point(4, 5, '#');
             p2.Draw();*/

            HorizontalLine LeftLine = new HorizontalLine(0,79,0,'$');
            LeftLine.Draw();
            HorizontalLine RightLine = new HorizontalLine(0,79, 78, '$');
            RightLine.Draw();
            VerticalLine UpLine = new VerticalLine(79, 0,78, '$');
            UpLine.Draw();
            VerticalLine DownLine = new VerticalLine(0, 0, 78, '$');
            DownLine.Draw();
            Console.ReadLine();
        }
     }
}
