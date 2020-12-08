using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster
{
    public class LinePainter : IPainter
    {
        LineFigure line;

        public LinePainter()
        {
            line = new LineFigure();
        }

        public LinePainter(Point firstPoint, Point LastPoint)
        {
            line = new LineFigure(firstPoint, LastPoint);
        }
        public Bitmap Paint(Bitmap Bm, Pen pen, Point firstPoint, Point LastPoint)
        {
            line.SetPoint(firstPoint, LastPoint);
            Bitmap tmpBM = (Bitmap) Bm.Clone();
            Graphics graphics = Graphics.FromImage(tmpBM);
            graphics.DrawPolygon(pen, line.GetPoints().ToArray());
            return tmpBM;
        }

    }
}
