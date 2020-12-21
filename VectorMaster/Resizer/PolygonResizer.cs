using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.Resizer
{
    public class PolygonResizer : IResizer
    {
        public List<Point> Resize(List<Point> Points, Point delta)
        {
            Point first = Points[0]; 
            for(int i = 1; i < Points.Count; ++i)
            {

            }
        }
    }
}
