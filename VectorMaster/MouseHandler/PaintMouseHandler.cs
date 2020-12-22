using System;
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
                canvas.currentFigure.listPoints = canvas.currentFigure.Calculate(canvas.prevPoint, canvas.CalculatePoint(canvas.curPoint));
                canvas.currentFigure.Paint();
            }

            canvas.pictureBox.Image = canvas.bitmap;
            canvas.bitmap = (Bitmap)bitmap.Clone();
        }

        public void RealizeMouseup()
        {

            Canvas canvas = Canvas.CreateCanvas();

            canvas.currentFigure.listPoints = canvas.currentFigure.Calculate(canvas.prevPoint, canvas.CalculatePoint(canvas.curPoint));

            canvas.currentFigure.pen = canvas.pen;

            if(canvas.currentFigure != null)
            {
                canvas.currentFigure.center = canvas.currentFigure.CalculateCenter();
                canvas.figures.Add(canvas.currentFigure);
                
                canvas.currentFigure.Paint();

            }

            canvas.prevPoint = canvas.curPoint;
        }
    }
}
