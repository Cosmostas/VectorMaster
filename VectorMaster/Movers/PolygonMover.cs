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

        public void MovePoints(Point delta, List<Point> points)
        {
            Canvas canvas = Canvas.CreateCanvas();
            List<Point> figurePoints = new List<Point>(canvas.currentFigure.listPoints);
            int j = 0;
            for (int i = 0; i < figurePoints.Count; ++i)
            {
                if (j == points.Count)
                {
                    break;
                }

                    if (canvas.currentFigure.listPoints[i] == points[j])
                    {
                        Point p = canvas.currentFigure.listPoints[i];
                        if(i == figurePoints.Count - 1)
                        {
                            canvas.currentFigure.listPoints[0] = new Point(p.X + delta.X, p.Y + delta.Y);

                        }
                        else
                        {
                            canvas.currentFigure.listPoints[i] = new Point(p.X + delta.X, p.Y + delta.Y);

                        }
                        p = points[j];

                        points[j] = new Point(p.X + delta.X, p.Y + delta.Y);
                        ++j;
                    }
                
            }

        }
    }
}
