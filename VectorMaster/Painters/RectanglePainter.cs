using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster
{
    public class RectanglePainter : IPainter
    {
        RectangleFigure rectangle;

        public RectanglePainter()
        {
            rectangle = new RectangleFigure();
        }

        public RectanglePainter(Point firstPoint, Point LastPoint)
        {
            rectangle = new RectangleFigure(firstPoint, LastPoint);
        }
        public Bitmap Paint(Bitmap Bm, Pen pen, Point firstPoint, Point LastPoint)
        {
            rectangle.SetPoint(firstPoint, LastPoint);
            Bitmap tmpBM = (Bitmap)Bm.Clone();
            Graphics graphics = Graphics.FromImage(tmpBM);
            graphics.DrawPolygon(pen, rectangle.GetPoints().ToArray());
            return tmpBM;
        }
    }
}
