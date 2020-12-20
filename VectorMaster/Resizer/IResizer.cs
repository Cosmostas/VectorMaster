using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.Resizer
{
    public interface IResizer
    {
        List<Point> Resize(List<Point> Points, Point delta);
    }
}
