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
        public void Paint(Pen pen, List<Point> listPoints)
        {
            BitmapSingleton bitmapSingleton = BitmapSingleton.CreateBitmap();
            Bitmap bitmap = bitmapSingleton.bitmap;
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawPolygon(pen, listPoints.ToArray());

        }

        public void Paint(Pen pen, List<Point> listPoints, float angle)
        {
            BitmapSingleton bitmapSingleton = BitmapSingleton.CreateBitmap();
            Bitmap bitmap = bitmapSingleton.bitmap;
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.RotateTransform(angle);
            graphics.DrawPolygon(pen, listPoints.ToArray());
        }
    }
}
