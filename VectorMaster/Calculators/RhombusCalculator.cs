using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.Calculators
{
    public class RhombusCalculator : ICalculator
    {
        public List<Point> Calculate(Point firstPoint, Point lastPoint)
        {
            int midpointX = Math.Abs(firstPoint.X - lastPoint.X);
            int midpointY = 0;
            int midpointRhombus = Math.Abs((lastPoint.Y - firstPoint.Y) / 2);

            if (firstPoint.Y < lastPoint.Y)
            {
                midpointY = firstPoint.Y + midpointRhombus;
            }
            else
            {
                midpointY = firstPoint.Y - midpointRhombus;
            }

            return new List<Point>(4)
            {
                firstPoint,
                new Point(firstPoint.X - midpointX, midpointY),
                new Point(firstPoint.X, lastPoint.Y),
                new Point(firstPoint.X + midpointX, midpointY)
            };

        }
    }
}
