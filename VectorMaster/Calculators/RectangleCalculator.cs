using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.Calculators
{
    public class RectangleCalculator : ICalculator
    {
        public List<Point> Calculate()
        {
            Canvas canvas = Canvas.CreateCanvas();
            Point firstPoint = canvas.prevPoint;
            Point lastPoint = canvas.CalculatePoint(canvas.curPoint);
            return new List<Point>(4) { firstPoint, new Point(lastPoint.X, firstPoint.Y), lastPoint, new Point(firstPoint.X, lastPoint.Y) };
        }

        public Point CalculateCenter()
        {
            Canvas canvas = Canvas.CreateCanvas();
            canvas.currentFigure.center = new Point((canvas.currentFigure.points[0].X + canvas.currentFigure.points[1].X) / 2, (canvas.currentFigure.points[0].Y + canvas.currentFigure.points[3].Y) / 2); ;
            return canvas.currentFigure.center;
        }
    }
}
