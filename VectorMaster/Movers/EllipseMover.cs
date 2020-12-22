using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.Movers
{
    public class EllipseMover : IMover
    {
        public void Move(Point delta, List<Point> points)
        {
            Point p = points[0];
            points[0] = new Point(p.X + delta.X, p.Y + delta.Y);
        }

        public void MovePoints(Point delta, List<Point> points)
        {
            Canvas canvas = Canvas.CreateCanvas();

            int pX = canvas.currentFigure.listPoints[0].X;
            int pY = canvas.currentFigure.listPoints[0].Y;
            int sizeX = canvas.currentFigure.listPoints[1].X;
            int sizeY = canvas.currentFigure.listPoints[1].Y;

            List<Point> dots = new List<Point>(4) { new Point(pX, pY + sizeY / 2), new Point(pX + sizeX / 2, pY), new Point(pX + sizeX, pY + sizeY / 2), new Point(pX + sizeX / 2, pY + sizeY) };




            if (points[0] == dots[0])
            {
                canvas.currentFigure.listPoints[0] = new Point(canvas.currentFigure.listPoints[0].X + delta.X /2, canvas.currentFigure.listPoints[0].Y); 
                canvas.currentFigure.listPoints[1] = new Point(canvas.currentFigure.listPoints[1].X - delta.X, canvas.currentFigure.listPoints[1].Y);
                points[0] = new Point(points[0].X + delta.X / 2, points[0].Y);
            }   
            else if(points[0] == dots[2])
            {
               canvas.currentFigure.listPoints[0] = new Point(canvas.currentFigure.listPoints[0].X - delta.X /2, canvas.currentFigure.listPoints[0].Y); 
               canvas.currentFigure.listPoints[1] = new Point(canvas.currentFigure.listPoints[1].X + delta.X, canvas.currentFigure.listPoints[1].Y);
               points[0] = new Point(canvas.currentFigure.listPoints[0].X + canvas.currentFigure.listPoints[1].X, points[0].Y);

            }
            else if(points[0] == dots[1])
            {
                canvas.currentFigure.listPoints[0] = new Point(canvas.currentFigure.listPoints[0].X, canvas.currentFigure.listPoints[0].Y + delta.Y /2);
                canvas.currentFigure.listPoints[1] = new Point(canvas.currentFigure.listPoints[1].X, canvas.currentFigure.listPoints[1].Y - delta.Y);
                points[0] = new Point(points[0].X, points[0].Y + delta.Y / 2);
            }
            else if (points[0] == dots[3])
            {
                canvas.currentFigure.listPoints[0] = new Point(canvas.currentFigure.listPoints[0].X, canvas.currentFigure.listPoints[0].Y - delta.Y /2);
                canvas.currentFigure.listPoints[1] = new Point(canvas.currentFigure.listPoints[1].X, canvas.currentFigure.listPoints[1].Y + delta.Y);
                points[0] = new Point(points[0].X, canvas.currentFigure.listPoints[0].Y + canvas.currentFigure.listPoints[1].Y);
            }
        
        }
    }
}

