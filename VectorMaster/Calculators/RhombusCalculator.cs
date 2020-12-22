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

        public Point MidpointCalculate()
        {
            int midpointX;
            int midpointY;
            int maxValueX;
            int maxValueY;
            int minValueX;
            int minValueY;

            Canvas canvas = Canvas.CreateCanvas(); ;

            maxValueX = canvas.currentFigure.listPoints[0].X;

            for (int i = 0; i < canvas.currentFigure.listPoints.Count; i++)
            {
                if (maxValueX < canvas.currentFigure.listPoints[i].X)
                {
                    maxValueX = canvas.currentFigure.listPoints[i].X;
                }
            }

            maxValueY = canvas.currentFigure.listPoints[0].Y;

            for (int i = 0; i < canvas.currentFigure.listPoints.Count; i++)
            {
                if (maxValueY < canvas.currentFigure.listPoints[i].Y)
                {
                    maxValueY = canvas.currentFigure.listPoints[i].Y;
                }
            }

            minValueX = canvas.currentFigure.listPoints[0].X;

            for (int i = 0; i < canvas.currentFigure.listPoints.Count; i++)
            {
                if (minValueX > canvas.currentFigure.listPoints[i].X)
                {
                    minValueX = canvas.currentFigure.listPoints[i].X;
                }
            }

            minValueY = canvas.currentFigure.listPoints[0].Y;

            for (int i = 0; i < canvas.currentFigure.listPoints.Count; i++)
            {
                if (minValueY > canvas.currentFigure.listPoints[i].Y)
                {
                    minValueY = canvas.currentFigure.listPoints[i].Y;
                }
            }

            midpointX = (maxValueX - minValueX) / 2 + minValueX;
            midpointY = (maxValueY - minValueY) / 2 + minValueY;

            return new Point(midpointX, midpointY);
        }
    }
}
