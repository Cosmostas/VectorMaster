﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.Movers
{
    public class PolygonMover : IMover
    {
        public void Move(Point delta, List<Point> points)
        {
            for (int i = 0; i < points.Count; i++)
            {
                Point p = points[i];
                points[i] = new Point(p.X + delta.X, p.Y + delta.Y);
            }
        }

        public void MovePoint(int index,  Point delta, List<Point> points)
        {
             Point p = points[index];
             points[index] = new Point(p.X + delta.X, p.Y + delta.Y);
        }

        public void MovePoints(Point delta, List<Point> points)
        {
            Canvas canvas = Canvas.CreateCanvas();
            List<Point> pointsToMove = new List<Point>();

            for (int i = 0; i < canvas.currentFigure.listPoints.Count; ++i)
            {
                if (0 == points.Count)
                {
                    break;
                }
                for(int j = 0; j< points.Count; ++j)
                {
                    if (canvas.currentFigure.listPoints[i] == points[j])
                    {
                        Point p = canvas.currentFigure.listPoints[i];
                        canvas.currentFigure.listPoints[i] = new Point(p.X + delta.X, p.Y + delta.Y);
                        p = points[j];

                        pointsToMove.Add(new Point(p.X + delta.X, p.Y + delta.Y));
                        points.RemoveAt(j);
                        break;

                    }
                }
            }
            points = new List<Point>(pointsToMove);



        }
    }
}
