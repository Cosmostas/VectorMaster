using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.Movers
{
    public class EllipseMover : IMover
    {
        public void Move(Point delta, List<Point> points)
        {
            Point p = points[0];
            points[0] = new Point(p.X + delta.X, p.Y + delta.Y);
        }
    }
}
