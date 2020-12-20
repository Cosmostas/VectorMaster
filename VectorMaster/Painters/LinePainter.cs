using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.Painters
{
    public class LinePainter : IPainter
    {
        public void Paint(Bitmap bitmap, Pen pen, List<Point> listPoints)
        {
            Graphics graphics = Graphics.FromImage(bitmap);
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            for(int i = 0; i < listPoints.Count - 1; i++)
            {
                graphics.DrawPolygon(pen, (new List<Point> { listPoints[i], listPoints[i + 1] }).ToArray());
            }
            
            
            /*float p1X = listPoints[0].X;
            float p1Y = listPoints[0].Y;
            float p2X = listPoints[1].X;
            float p2Y = listPoints[1].Y;
            graphics.DrawLine(pen, p1X, p1Y, p2X, p2Y);*/

        }

        public void Paint(Pen pen, List<Point> listPoints)
        {
            throw new NotImplementedException();
        }

        public void Paint(Pen pen, List<Point> listPoints, float angle)
        {
            throw new NotImplementedException();
        }
    }
}
