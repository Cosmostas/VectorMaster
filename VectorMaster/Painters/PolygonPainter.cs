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
        public void Paint(Bitmap bitmap, Pen pen, List<Point> listPoints)
        {
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawPolygon(pen, listPoints.ToArray());

        }

        public void Paint(Bitmap bitmap, Pen pen, List<Point> listPoints, float angle)
        {
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.RotateTransform(angle);
            graphics.DrawPolygon(pen, listPoints.ToArray());
        }
    }
}
