using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.Factory
{
    public class RectangleFactory : IFactory
    {
        public AFigure CreateFigure()
        {
            return new IsoscelesTriangleTestFigure();
        }
        public AFigure CreateFigure(Pen pen)
        {
            return new IsoscelesTriangleTestFigure(pen);
        }
    }
}
