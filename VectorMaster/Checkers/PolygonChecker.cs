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
        public bool CheckHit(Point dot, List<Point> Points, int Width)
        {

            Point start;
            Point end;

            List<Point> linePoints = new List<Point>(Points);
            linePoints.Add(Points[0]);
            for (int i = 0; i <= Points.Count - 1; ++i)
            {
                start = linePoints[i];
                end = linePoints[i + 1];

                if (
                    Math.Abs((dot.X - start.X) * (end.Y - start.Y) - (dot.Y - start.Y) * (end.X - start.X)) <= Width  * Math.Sqrt((end.X - start.X)* (end.X - start.X) + (end.X - start.X)* (end.X - start.X))// line contain dot

                    &&
                    (
                        (dot.X <= start.X && dot.Y <= start.Y && dot.X >= end.Y && dot.Y >= end.Y)
                        ||                                                                              // dot locate between star and end of line 
                        (dot.X >= start.X && dot.Y >= start.Y && dot.X <= end.Y && dot.Y <= end.Y)
                    )

                    )
                {
                    return true;
                }
            }
            return false;
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
