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
        

        int index = -1;

        public bool CheckHit(Point dot, List<Point> Points, int Width)
        {
            Point startAccuracyLine = new Point(dot.X - Width / 2, dot.Y - Width / 2);
            Point endAccuracyLine = new Point(dot.X + Width / 2, dot.Y + Width / 2);

            List<Point> figurePoints = new List<Point>(Points);
            figurePoints.Add(Points[Points.Count - 1]);

            Point startFigureLine;
            Point endFigureLine;

            for (int i = 0; i < figurePoints.Count - 1; ++i)
            {
                startFigureLine = Points[i];
                endFigureLine = Points[i + 1];

            }
        }

        public int CheckHitInVertex(Point dot, List<Point> Points)
        {
            for (int i = 0; i < Points.Count; i++)
            {
                if (Math.Abs(Points[i].X - dot.X) < 5 && Math.Abs(Points[i].Y - dot.Y) < 5)
                {
                    index = i;
                }
            }
            return index;
        }

    }
}

/*
       double x1 = start.X;
            double y1 = start.Y;
            double x2 = end.X;
            double y2 = end.Y;
            double x = checkPoint.X;
            double y = checkPoint.Y;

            if (CheckInside(x, x1, x2, accuracy) && CheckInside(y, y1, y2, accuracy))
                    return Math.Abs((x - x1) * (y2 - y1) - (y - y1) * (x2 - x1)) < accuracy / 2 * Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            else return false;
        }

        private bool CheckInside(double x, double a, double b, double accuracy)
        {
            if ((x > a - accuracy && x < b + accuracy) || (x > b - accuracy && x < a + accuracy))
                return true;
            else return false;
        }
 */


/*
 * 
 public bool CheckHit(Point dot, List<Point> Points, int Width)
    {
        float k1, k2, b1, b2;
        float x, y;


        Point startAccuracyLine = new Point(dot.X - Width/2, dot.Y - Width / 2);
        Point endAccuracyLine = new Point(dot.X + Width / 2, dot.Y + Width / 2);

        k1 = (endAccuracyLine.Y - startAccuracyLine.Y) / (endAccuracyLine.X - startAccuracyLine.X);


        b1 = endAccuracyLine.Y - k1 * endAccuracyLine.X;

        Point startFigureLine;
        Point endFigureLine;

        for(int i = 0; i < Points.Count - 1; ++i)
        {
            startFigureLine = Points[i];
            endFigureLine = Points[i+1];


            if(startFigureLine.X > endFigureLine.X)
            {
                Point tmp = startFigureLine;
                startFigureLine = endFigureLine;
                endFigureLine = tmp;
            }

            if(startFigureLine.X == endFigureLine.X)
            {
                x = startFigureLine.X;

                y = k1 * x + b1;

                if ((x - startAccuracyLine.X) / (endAccuracyLine.X - startAccuracyLine.X) == (y - startAccuracyLine.Y) / (endAccuracyLine.Y - startAccuracyLine.Y)) return true;

                else
                {
                    continue;
                }
            }

             k2 = (endFigureLine.Y - startFigureLine.Y) / (endFigureLine.X - startFigureLine.X);


            if(k1 == k2)
            {
                continue;
            }

            b2 = endFigureLine.Y - k1 * endFigureLine.X;

            x = (b2 - b1) / (k1 - k2);

            y = k1 * x + b1;

            //if (
            //    (startAccuracyLine.X <= endFigureLine.X && endFigureLine.X <= endAccuracyLine.X)
            //    ||
            //    (startAccuracyLine.X <= startFigureLine.X && startFigureLine.X <= endAccuracyLine.X)
            //    )
            //{

            //    return true;
            //}
            //if ((x - startAccuracyLine.X) / (endAccuracyLine.X - startAccuracyLine.X) == (y - startAccuracyLine.Y) / (endAccuracyLine.Y - startAccuracyLine.Y)) return true;

        }
        return false;
    }
 */
