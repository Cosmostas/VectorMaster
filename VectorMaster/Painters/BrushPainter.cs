﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.Painters
{
    public class BrushPainter : IPainter
    {


        public void Paint(Pen pen, List<Point> listPoints)
        {
            
            Canvas canvas = Canvas.CreateCanvas();
            Graphics graphics = Graphics.FromImage(canvas.bitmap);
            
            for (int i = 0; i < listPoints.Count - 1; i++)
            {
                graphics.DrawPolygon(pen, (new List<Point> { listPoints[i], listPoints[i + 1] }).ToArray());
            }
        }

        public void Paint(Pen pen, List<Point> listPoints, float angle)
        {
            Canvas canvas = Canvas.CreateCanvas();
            Graphics graphics = Graphics.FromImage(canvas.bitmap);
            
            for (int i = 0; i < listPoints.Count - 1; i++)
            {
                
                graphics.DrawPolygon(pen, (new List<Point> { listPoints[i], listPoints[i + 1] }).ToArray());
            }
        }

        public void PaintDots(Pen pen, List<Point> listPoints)
        {
 
        }
    }
}
