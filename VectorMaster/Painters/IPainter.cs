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
        Bitmap Paint(Bitmap Bm, Pen pen, Point firstPoint, Point LastPoint);   
    }
}
