using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorMaster.Figures;

namespace VectorMaster.Factory
{
    public class IsoscelesTriangleFactory : IFactory
    {
        public AFigure CreateFigure()
        {
            return new IsoscelesTriangleFigure();
        }

        public AFigure CreateFigure(Pen pen)
        {
            return new IsoscelesTriangleFigure(pen);
        }
    }
}
