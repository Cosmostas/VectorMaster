using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster
{
    public interface IPainter
    {
        void Paint(Pen pen, List<Point> listPoints);     
        void Paint(Pen pen, List<Point> listPoints, float angle);   
    }
}
