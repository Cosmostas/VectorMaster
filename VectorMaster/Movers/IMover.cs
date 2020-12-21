using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.Movers
{
    public interface IMover
    {
        void Move(Point delta, List<Point> points);
        void MovePoints(Point delta, List<Point> points);
    }
}
