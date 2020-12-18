﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.Movers
{
    public class RectangleMover : IMover
    {
        public void Move(Point delta, List<Point> points)
        {
            for (int i = 0; i < points.Count; i++)
            {
                Point p = points[i];
                points[i] = new Point(p.X + delta.X, p.Y + delta.Y);
            }
        }
    }
}
