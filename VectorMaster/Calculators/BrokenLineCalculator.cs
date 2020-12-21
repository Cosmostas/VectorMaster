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
            Canvas canvas = Canvas.CreateCanvas();
            List <Point>Points = new List<Point>(canvas.currentFigure.listPoints);
            
            Points.Add(canvas.curPoint);
            return Points;

        }
    }
}
