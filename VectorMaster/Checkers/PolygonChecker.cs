using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.Checkers
{
    class PolygonChecker : IChecker
    {
        

        public List<Point> CheckHit(Point dot, List<Point> Points, int Width)
        {
            Canvas canvas = Canvas.CreateCanvas();

            if (canvas.currentFigure != null)
            {
                Points.Add(canvas.currentFigure.center);
            }
            for (int i = 0; i < Points.Count; i++)
            {
                if (Math.Abs(Points[i].X - dot.X) < Width / 2 && Math.Abs(Points[i].Y - dot.Y) < Width / 2)
                {
                    return new List<Point>(1) { Points[i] };
                }
            }


            Point startAccuracyLine1 = new Point(dot.X - Width / 2, dot.Y - Width / 2);
            Point endAccuracyLine1 = new Point(dot.X + Width / 2, dot.Y + Width / 2);
            
            Point startAccuracyLine2 = new Point(dot.X - Width / 2, dot.Y + Width / 2);
            Point endAccuracyLine2 = new Point(dot.X + Width / 2, dot.Y - Width / 2);
           
            List<Point> figurePoints = new List<Point>(Points);
            figurePoints.Add(Points[0]);

            Point startFigureLine;
            Point endFigureLine;

            for (int i = 0; i < figurePoints.Count - 1; ++i)
            {
                startFigureLine = figurePoints[i];
                endFigureLine = figurePoints[i + 1];

                if(
                    checkСrossingLine(startAccuracyLine1, endAccuracyLine1, startFigureLine, endFigureLine, dot, Width)
                    ||
                    checkСrossingLine(startAccuracyLine2, endAccuracyLine2, startFigureLine, endFigureLine, dot, Width)
                    )
                {
                    return new List<Point>(2) { startFigureLine, endFigureLine};
                }


            }
            return null;
        }

        bool checkСrossingLine(Point startAccuracyLine, Point endAccuracyLine, Point startFigureLine, Point endFigureLine, Point dot, int Width)
        {
            if (Math.Abs(startFigureLine.X -  endFigureLine.X) > Width)
            {
                float k = (float)(endFigureLine.Y - startFigureLine.Y) / (float)(endFigureLine.X - startFigureLine.X);
                float b = endFigureLine.Y - endFigureLine.X * k;

                float y = dot.X * k + b;

                if (y >= endAccuracyLine.Y && y <= startAccuracyLine.Y
                    ||
                    y <= endAccuracyLine.Y && y >= startAccuracyLine.Y
                    )
                {
                    float x = dot.X;
                    if (x >= endFigureLine.X && x <= startFigureLine.X
                       ||
                       x <= endFigureLine.X && x >= startFigureLine.X
                       )
                    {
                        return true;
                    }

                }
            }
            else
            {
                float x = startFigureLine.X;
                if (x >= endAccuracyLine.X && x <= startAccuracyLine.X
                    ||
                    x <= endAccuracyLine.X && x >= startAccuracyLine.X
                    )
                {
                    float y = dot.Y;
                    if (y >= endFigureLine.Y && y <= startFigureLine.Y
                       ||
                       y <= endFigureLine.Y && y >= startFigureLine.Y
                       )
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
