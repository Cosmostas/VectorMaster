using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorMaster.Factory;

namespace VectorMaster.MouseHandler
{
    public interface IMouseHandler
    {
        void RealizeMouseDown();
        void RealizeMouseMove(Point mouseLocation);
        void RealizeMouseup();


    }
}
