using System;
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
            canvas.currentFigure.listPoints.Add(canvas.curPoint);
        }

        public void RealizeMouseMove()
        {
            Canvas canvas = Canvas.CreateCanvas();

            canvas.currentFigure.listPoints.Add(canvas.curPoint);
            canvas.prevPoint = canvas.curPoint;
            canvas.currentFigure.Paint();
        }

        public void RealizeMouseup()
        {
            Canvas canvas = Canvas.CreateCanvas();

            canvas.currentFigure.listPoints.Add(canvas.curPoint);

            if (canvas.currentFigure != null)
            {
                canvas.figures.Add(canvas.currentFigure);
                canvas.currentFigure.Paint();
            }

            canvas.prevPoint = canvas.curPoint;
        }
    }
}
