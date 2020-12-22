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
        public List<Point> Calculate()
        {
            Canvas canvas = Canvas.CreateCanvas();
            List <Point>Points = new List<Point>(canvas.currentFigure.points);
            
            Points.Add(canvas.curPoint);
            return Points;

        }

        public Point CalculateCenter()
        {
            throw new NotImplementedException();
        }
    }
}
