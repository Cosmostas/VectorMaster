using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.Calculators
{
    public class RightTriangleCalculator : ICalculator
    {
        public List<Point> Calculate()
        {
            Canvas canvas = Canvas.CreateCanvas();
            Point firstPoint = canvas.prevPoint;
            Point lastPoint = canvas.curPoint;
            return new List<Point>(3) { firstPoint, new Point(firstPoint.X, lastPoint.Y), lastPoint };
        }

        public Point CalculateCenter()
        {
            throw new NotImplementedException();
        }
    }
}
