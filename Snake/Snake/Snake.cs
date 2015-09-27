﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake:Figura
    {
        public Snake(Point Tail, int Lenght, Direction Direction)
        {
            pList = new List<Point>();  
            for (int i = 0; i < Lenght; i++)
            {
                Point p = new Point(Tail);
                p.Move(i, Direction);
                pList.Add(p);  
            }
        }
    }
}
