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

            canvas.prevPoint = canvas.curPoint;
        }

        public void RealizeMouseMove() {

            Canvas canvas = Canvas.CreateCanvas();
            Bitmap bitmap = (Bitmap)canvas.bitmap.Clone();

            if(canvas.currentFigure != null && canvas.isMouseDown)
            {
                canvas.currentFigure.points = canvas.currentFigure.Calculate();
                canvas.currentFigure.Paint();
            }

            canvas.pictureBox.Image = canvas.bitmap;
            canvas.bitmap = (Bitmap)bitmap.Clone();
        }

        public void RealizeMouseup()
        {

            Canvas canvas = Canvas.CreateCanvas();

            canvas.currentFigure.points = canvas.currentFigure.Calculate();


            if(canvas.currentFigure != null)
            {
                canvas.currentFigure.pen = new Pen(canvas.pen.Color, canvas.pen.Width);
                
                canvas.figures.Add(canvas.currentFigure);
                
                canvas.currentFigure.Paint();

            }

            canvas.prevPoint = canvas.curPoint;
        }
    }
}
