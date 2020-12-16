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
    }
}
