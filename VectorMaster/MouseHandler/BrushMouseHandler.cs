﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.MouseHandler
{
    public class BrushMouseHandler : IMouseHandler
    {
        public void RealizeMouseDown()
        {
            Canvas canvas = Canvas.CreateCanvas();

            canvas.currentFigure = canvas.factory.CreateFigure(canvas.pen);
            canvas.currentFigure.points.Add(canvas.curPoint);
        }

        public void RealizeMouseMove()
        {

       
            Canvas canvas = Canvas.CreateCanvas();
            Bitmap bitmap = (Bitmap)canvas.bitmap.Clone();

            if (canvas.currentFigure != null && canvas.isMouseDown)
            {
                canvas.currentFigure.points.Add(canvas.curPoint);
                canvas.currentFigure.Paint();

            }

            canvas.prevPoint = canvas.curPoint;
            canvas.pictureBox.Image = canvas.bitmap;
            canvas.bitmap = (Bitmap)bitmap.Clone();
        }

        public void RealizeMouseup()
        {
            Canvas canvas = Canvas.CreateCanvas();

            canvas.currentFigure.points.Add(canvas.curPoint);

            if (canvas.currentFigure != null)
            {
                canvas.currentFigure.pen = new Pen(canvas.currentFigure.pen.Color, canvas.currentFigure.pen.Width);
                canvas.figures.Add(canvas.currentFigure);
                canvas.currentFigure.Paint();
            }

            canvas.prevPoint = canvas.curPoint;
        }
    }
}
