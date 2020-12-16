using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.Calculators
{
    public class EllipseCalculator : ICalculator
    {
        public List<Point> Calculate(Point firstPoint, Point lastPoint)
        {
            int sizeX = Math.Abs(firstPoint.X - lastPoint.X);
            int sizeY = Math.Abs(firstPoint.Y - lastPoint.Y);

            return new List<Point>(2) 
            {
                firstPoint,
                new Point(sizeX, sizeY)
            };
        }
    }
}
