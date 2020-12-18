using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.Calculators
{
    public class BrokenLineCalculator : ICalculator
    {
        public List<Point> Calculate(Point firstPoint, Point lastPoint)
        {
            return new List<Point>() { firstPoint, lastPoint };

        }
    }
}
