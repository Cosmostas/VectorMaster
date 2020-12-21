using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.Checkers
{
    public interface IChecker
    {
        List<Point> CheckHit(Point dot, List<Point> Points, int Width);
        int CheckHitInVertex(Point dot, List<Point> Points);
    }
}
