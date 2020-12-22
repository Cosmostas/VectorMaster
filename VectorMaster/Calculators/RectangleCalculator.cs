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
        public List<Point> Calculate(Point firstPoint, Point lastPoint)
        {
            return new List<Point>(4) { firstPoint, new Point(lastPoint.X, firstPoint.Y), lastPoint, new Point(firstPoint.X, lastPoint.Y) };
        }

        public Point CalculateCenter()
        {
            Canvas canvas = Canvas.CreateCanvas();
            canvas.currentFigure.center = new Point((canvas.currentFigure.listPoints[0].X + canvas.currentFigure.listPoints[1].X) / 2, (canvas.currentFigure.listPoints[0].Y + canvas.currentFigure.listPoints[3].Y) / 2); ;
            return canvas.currentFigure.center;
        }
    }
}
