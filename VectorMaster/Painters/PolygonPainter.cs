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
            Canvas canvas = Canvas.CreateCanvas();
            Bitmap bitmap = canvas.bitmap;
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawPolygon(pen, listPoints.ToArray());

        }

        public void Paint(Pen pen, List<Point> listPoints, float angle)
        {
            Canvas canvas = Canvas.CreateCanvas ();
            Bitmap bitmap = canvas.bitmap;
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.RotateTransform(angle);
            graphics.DrawPolygon(pen, listPoints.ToArray());
        }

        public void PaintDots(Pen pen, List<Point> listPoints)
        {
            Canvas canvas = Canvas.CreateCanvas();
            Bitmap bitmap = canvas.bitmap;
            Graphics graphics = Graphics.FromImage(bitmap);
            int radius;
            foreach (Point point in listPoints)
            {
                SolidBrush blackBrush = new SolidBrush(Color.Black);
                SolidBrush whiteBrush = new SolidBrush(Color.White);

                //int radius = (int)(pen.Width + 6);

                //graphics.DrawEllipse(new Pen(Color.White, pen.Width / 3), point.X  - radius, point.Y - radius, 2*radius, 2*radius);

                //radius = (int)(pen.Width) / 2;
                //graphics.DrawEllipse(new Pen(Color.Blue, pen.Width / 3), point.X - radius, point.Y - radius, 2 * radius, 2 * radius);

                radius = (int)(pen.Width / 2);
                graphics.DrawEllipse(new Pen(Color.White, pen.Width / 3), point.X - radius, point.Y - radius, 2 * radius, 2 * radius);
                graphics.FillEllipse(blackBrush, point.X - radius + 1, point.Y - radius + 1, 2 * (radius - 2), 2 * (radius-2));

            }
            Point center = canvas.currentFigure.center;
            radius = (int)(pen.Width / 2);
            graphics.DrawEllipse(new Pen(Color.Black, pen.Width / 3), center.X - radius - 2, center.Y - radius - 2, 2 * (radius + 2), 2 * (radius + 2));
            graphics.DrawEllipse(new Pen(Color.White, pen.Width / 3), center.X - radius, center.Y - radius, 2 * radius, 2 * radius);
            graphics.FillEllipse(new SolidBrush(Color.Black), center.X - radius + 2, center.Y - radius + 2, 2 * (radius - 2), 2 * (radius - 2));
        }
    }
}
