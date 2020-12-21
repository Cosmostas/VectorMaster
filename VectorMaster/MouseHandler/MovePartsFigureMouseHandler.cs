﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.MouseHandler
{
    public class MovePartsFigureMouseHandler : IMouseHandler
    {
        List<Point> points;
        Point deltaObs = new Point(0,0);
        public void RealizeMouseDown()
        {
            Canvas canvas = Canvas.CreateCanvas();

            canvas.currentFigure = null;

            foreach (AFigure figure in canvas.figures)
            {
                points = figure.CheckHit(canvas.curPoint);
                if (points != null)
                {
                    canvas.currentFigure = figure;
                    canvas.figures.Remove(canvas.currentFigure);
                    canvas.DrawAll();
                    canvas.pen = figure.pen;
                    break;
                }
            }
        }

        public void RealizeMouseMove()
        {
            Canvas canvas = Canvas.CreateCanvas();

            Point delta = new Point(canvas.curPoint.X - canvas.prevPoint.X, canvas.curPoint.Y - canvas.prevPoint.Y);
            canvas.currentFigure.MovePoints(delta, points);

            canvas.prevPoint = canvas.curPoint;
            canvas.currentFigure.Paint();

        }

        public void RealizeMouseup()
        {
            Canvas canvas = Canvas.CreateCanvas();

            if (canvas.currentFigure != null)
            {


                canvas.figures.Add(canvas.currentFigure);
                canvas.currentFigure.Paint();
            }

            canvas.prevPoint = canvas.curPoint;
        }
    }
}
