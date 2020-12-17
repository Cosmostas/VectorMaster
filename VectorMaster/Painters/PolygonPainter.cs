using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster
{
    public class PolygonPainter : IPainter
    {
        public void Paint(Bitmap Bm, Pen pen, List<Point> listPoints)
        {
            Graphics graphics = Graphics.FromImage(Bm);
            graphics.DrawPolygon(pen, listPoints.ToArray());

        }

    }
}
