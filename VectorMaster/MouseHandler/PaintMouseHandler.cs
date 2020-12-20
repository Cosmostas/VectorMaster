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
            Canvas canvas = Canvas.CreateBitmap();

            canvas.currentFigure = canvas.factory.CreateFigure(canvas.pen);
        }

        public void RealizeMouseMove(Point mouseLocation) { 

            Canvas canvas = Canvas.CreateBitmap();

            canvas.currentFigure.listPoints = canvas.currentFigure.Calculate(canvas.prevPoint, canvas.CalculatePoint(mouseLocation));
            canvas.currentFigure.Paint();

        }

        public void RealizeMouseup()
        {
            throw new NotImplementedException();
        }
    }
}
