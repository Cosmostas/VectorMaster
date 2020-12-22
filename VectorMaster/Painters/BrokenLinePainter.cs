using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.Painters
{
    public class BrokenLinePainter : IPainter
    {
        public void Paint(Pen pen, List<Point> listPoints)
        {
            Canvas canvas = Canvas.CreateCanvas();
            Graphics graphics = Graphics.FromImage(canvas.bitmap);
            for(int i = 0; i < listPoints.Count - 1; ++i)
            {
                graphics.DrawPolygon(pen, new Point[2] { listPoints[i], listPoints[i + 1] });
            }
        }

        public void Paint(Pen pen, List<Point> listPoints, float angle)
        {
            throw new NotImplementedException();
        }

        public void PaintDots(Pen pen, List<Point> listPoints)
        {
            throw new NotImplementedException();
        }
    }
}
