using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake:Figura
    {
       Direction Direction;
        public Snake(Point Tail, int Lenght, Direction _Direction)
        {
            Direction = _Direction;
            pList = new List<Point>();  
            for (int i = 0; i < Lenght; i++)
            {
                Point p = new Point(Tail);
                p.Move(i, Direction);
                pList.Add(p);  
            }
        }

        internal void Move()
        {
            Point Tail = pList.First();
            pList.Remove(Tail);
            Point Head = GetNextPoint();
            pList.Add(Head);

            Tail.Clear();
            Head.Draw();
                   }
        public Point GetNextPoint()
        {
            Point Head = pList.Last();
            Point NextPoint = new Point(Head);
            NextPoint.Move(1, Direction);
            return NextPoint;
        }
        public void HandleKey(ConsoleKey Key)
        {
            
            if (Key == ConsoleKey.LeftArrow)
                Direction = Direction.LEFT;
            else if (Key == ConsoleKey.RightArrow)
                Direction = Direction.RIGHT;
            else if (Key == ConsoleKey.UpArrow)
                Direction = Direction.UP;
            else if (Key == ConsoleKey.DownArrow)
                Direction = Direction.DOWN;
        }
    }
}
