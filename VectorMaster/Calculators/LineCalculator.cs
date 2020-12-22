using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.Calculators
{
    public class LineCalculator : ICalculator
    {
        public List<Point> Calculate()
        {
            Canvas canvas = Canvas.CreateCanvas();
            Point firstPoint = canvas.prevPoint;
            Point lastPoint = canvas.curPoint;
            return new List<Point>(2) { firstPoint, lastPoint };
        }

        public Point CalculateCenter()
        {
            throw new NotImplementedException();
        }
    }
}
