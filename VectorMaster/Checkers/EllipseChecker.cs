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
            if (
                Math.Abs(dot.X  - Center.X) > Points[1].X - Width
                &&
                Math.Abs(dot.Y - Center.Y) < Points[1].Y + Width
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
