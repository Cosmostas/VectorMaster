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

            /*for (new Point = 1; new Point = (Point lastPoint ); new Point++)
            {
                return new List<Point>(3) { firstPoint, new Point(), lastPoint };
            }
            Through for send list of points and increase by 1. 

            */
            return new List<Point>() { firstPoint, new Point((Size)lastPoint), lastPoint };
        }
    }
}
