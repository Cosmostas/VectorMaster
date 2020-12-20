using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.MouseHandler
{
    public class MoveMouseHandler : IMouseHandler
    {
        public void RealizeMouseDown()
        {
            Canvas canvas = Canvas.CreateCanvas();

            canvas.currentFigure = null;

            foreach (AFigure figure in canvas.figures)
            {
                if (figure.CheckHit(canvas.curPoint))
                {
                    canvas.currentFigure = figure;
                    canvas.figures.Remove(canvas.currentFigure);
                    canvas.DrawAll();
                    canvas.pen = figure.pen;
                    break;
                }
            }
        }

        public void RealizeMouseMove(Point mouseLocation)
        {
            Canvas canvas = Canvas.CreateCanvas();

            Point delta = new Point(canvas.curPoint.X - canvas.prevPoint.X, canvas.curPoint.Y - canvas.prevPoint.Y);
            canvas.currentFigure.Move(delta, canvas.currentFigure.listPoints);
            canvas.prevPoint = canvas.curPoint;
            canvas.currentFigure.Paint();

        }

        public void RealizeMouseup(Point mouseLocation)
        {
            Canvas canvas = Canvas.CreateCanvas();

            if (canvas.currentFigure != null)
            {
                canvas.figures.Add(canvas.currentFigure);
                canvas.currentFigure.Paint();

            }

            canvas.prevPoint = mouseLocation;
        }
    }
}
