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
            foreach(Point point in listPoints)
            {
                Canvas canvas = Canvas.CreateCanvas();
                Bitmap bitmap = canvas.bitmap;
                Graphics graphics = Graphics.FromImage(bitmap);
                SolidBrush blackBrush = new SolidBrush(Color.Black);
                SolidBrush whiteBrush = new SolidBrush(Color.White);
                graphics.FillEllipse(blackBrush, point.X, point.Y, pen.Width + 1, pen.Width + 1);
                graphics.FillEllipse(whiteBrush, point.X, point.Y, pen.Width - 1, pen.Width - 1);

            }
        }
    }
}
