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
        public List<Point> Calculate()
        {

            Canvas canvas = Canvas.CreateCanvas();
            Point firstPoint = canvas.prevPoint;
            Point lastPoint = canvas.curPoint;

            Point startPoint;

            if(firstPoint.X < lastPoint.X)
            {
                if (firstPoint.Y < lastPoint.Y)
                {
                    startPoint = firstPoint;
                }
                else
                {
                    startPoint = new Point(firstPoint.X, lastPoint.Y);
                }
            }
            else
            {
                if (firstPoint.Y < lastPoint.Y)
                {
                    startPoint = new Point(lastPoint.X, firstPoint.Y);
                }
                else
                {
                    startPoint = lastPoint;
                }
            }

            int sizeX = Math.Abs(firstPoint.X - lastPoint.X);
            int sizeY = Math.Abs(firstPoint.Y - lastPoint.Y);

            return new List<Point>(2) 
            {
                startPoint,
                new Point(sizeX, sizeY)
            };
        }

        public Point CalculateCenter()
        {
            throw new NotImplementedException();
        }
    }
}
