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
            Canvas canvas = Canvas.CreateCanvas();
            Bitmap bitmap = canvas.bitmap;

            Graphics graphics = Graphics.FromImage(bitmap);

            pX = listPoints[0].X;
            pY = listPoints[0].Y;
            sizeX = listPoints[1].X;
            sizeY = listPoints[1].Y;

            graphics.DrawEllipse(pen, pX, pY, sizeX, sizeY);


        }

        public void PaintDots(Pen pen, List<Point> points)
        {

            List<Point> dots = new List<Point>(4) { new Point(pX, pY + sizeY / 2) , new Point(pX + sizeX / 2, pY), new Point(pX + sizeX, pY + sizeY / 2), new Point(pX + sizeX / 2, pY + sizeY) };

            foreach(Point point in dots)
            {
                Canvas canvas = Canvas.CreateCanvas();
                Bitmap bitmap = canvas.bitmap;
                Graphics graphics = Graphics.FromImage(bitmap);
                SolidBrush blackBrush = new SolidBrush(Color.Black);
                SolidBrush whiteBrush = new SolidBrush(Color.White);


                int radius = (int)(pen.Width / 2);
                graphics.DrawEllipse(new Pen(Color.White, pen.Width / 3), point.X - radius, point.Y - radius, 2 * radius, 2 * radius);
            }
        }
    }
}
