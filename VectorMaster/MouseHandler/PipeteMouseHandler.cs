using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.MouseHandler
{
    public class PipeteMouseHandler : IMouseHandler
    {
        public void RealizeMouseDown()
        {
            Canvas canvas = Canvas.CreateCanvas();
            canvas.prevPoint = canvas.curPoint;
        }

        public void RealizeMouseMove()
        {

        }

        public void RealizeMouseup()
        {
            Canvas canvas = Canvas.CreateCanvas();
            canvas.pen.Color = canvas.bitmap.GetPixel(canvas.curPoint.X, canvas.curPoint.Y);
        }
    }
}
