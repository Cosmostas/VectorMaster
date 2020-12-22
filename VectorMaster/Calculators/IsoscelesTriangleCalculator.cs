using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.Calculators
{
    public class IsoscelesTriangleCalculator : ICalculator
    {
        public List<Point> Calculate(Point firstPoint, Point lastPoint)
        {
            return new List<Point>(3) { firstPoint, new Point(firstPoint.X - (lastPoint.X - firstPoint.X), lastPoint.Y), lastPoint };
        }

        public Point CalculateCenter()
        {
            throw new NotImplementedException();
        }
    }
}
