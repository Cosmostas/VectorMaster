﻿using System;
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

        public void PaintDots(Pen pen, List<Point> listPoints)
        {
            Canvas canvas = Canvas.CreateCanvas();
            Bitmap bitmap = canvas.bitmap;
            Graphics graphics = Graphics.FromImage(bitmap);
            int radius;
            foreach (Point point in listPoints)
            {

                radius = (int)(pen.Width / 2);
                graphics.DrawEllipse(new Pen(Color.Black, pen.Width / 3), point.X - radius - 2, point.Y - radius - 2, 2 * (radius + 2), 2 * (radius + 2));
                graphics.DrawEllipse(new Pen(Color.White, pen.Width / 3), point.X - radius, point.Y - radius, 2 * radius, 2 * radius);
                graphics.FillEllipse(new SolidBrush(Color.Black), point.X - radius + 2, point.Y - radius + 2, 2 * (radius - 2), 2 * (radius - 2));

            }
            
        }
    }
}
