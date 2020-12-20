using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.Checkers
{
    public class EllipseChecker : IChecker
    {
        public bool CheckHit(Point dot, List<Point> Points, int Width)
        {
            Point Center = new Point(Points[0].X + Points[1].X / 2, Points[0].Y + Points[1].Y / 2);
            int len = (int)Math.Sqrt((dot.X - Points[0].X)* (dot.X - Points[0].X) + (dot.Y - Points[0].Y)* (dot.Y - Points[0].Y));
            if ( (Math.Abs(len - Points[1].X / 2) < Width / 2 && Math.Abs(len - Points[1].X / 2) > 0)
                ||
                (Math.Abs(len - Points[1].Y / 2) <  Width / 2 && Math.Abs(len - Points[1].Y / 2) > 0)

                )
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
