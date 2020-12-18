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
                    (dot.X - start.X) * (end.Y - start.Y) - (dot.Y - start.Y) * (end.X - start.X) <= Width / 2
                    &&                                                                                             // line contain dot
                    (dot.X - start.X) * (end.Y - start.Y) - (dot.Y - start.Y) * (end.X - start.X) >= -Width / 2
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
