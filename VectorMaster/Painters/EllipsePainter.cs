using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.Painters
{
    public class EllipsePainter : IPainter
    {
        int pX;
        int pY;
        int sizeX;
        int sizeY;

        public void Paint(Pen pen, List<Point> listPoints)
        {
            BitmapSingleton bitmapSingleton = BitmapSingleton.CreateBitmap();
            Bitmap bitmap = bitmapSingleton.bitmap;

            Graphics graphics = Graphics.FromImage(bitmap);

            pX = listPoints[0].X;
            pY = listPoints[0].Y;
            sizeX = listPoints[1].X;
            sizeY = listPoints[1].Y;

            graphics.DrawEllipse(pen, pX, pY, sizeX, sizeY);


        }

        public void Paint( Pen pen, List<Point> listPoints, float angle)
        {
            throw new NotImplementedException();
        }
    }
}
