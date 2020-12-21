﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorMaster.Factory;


namespace VectorMaster.MouseHandler
{
    public class PaintMouseHandler : IMouseHandler
    {

        public void RealizeMouseDown()
        {
            Canvas canvas = Canvas.CreateCanvas();

            canvas.currentFigure = canvas.factory.CreateFigure(canvas.pen);
        }

        public void RealizeMouseMove() { 

            Canvas canvas = Canvas.CreateCanvas();

            canvas.currentFigure.listPoints = canvas.currentFigure.Calculate(canvas.prevPoint, canvas.CalculatePoint(canvas.curPoint));
            canvas.currentFigure.Paint();

        }

        public void RealizeMouseup()
        {
            Canvas canvas = Canvas.CreateCanvas();

            canvas.currentFigure.listPoints = canvas.currentFigure.Calculate(canvas.prevPoint, canvas.CalculatePoint(canvas.curPoint));
            if(canvas.currentFigure != null)
            {
                canvas.figures.Add(canvas.currentFigure);
                canvas.currentFigure.Paint();

            }

            canvas.prevPoint = canvas.curPoint;
        }
    }
}
