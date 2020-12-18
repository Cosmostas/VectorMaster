using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorMaster.Calculators;
using VectorMaster.Painters;
using VectorMaster.Checkers;
using VectorMaster.Movers;

namespace VectorMaster.Figures
{
    public class EllipseFigure : AFigure
    {
        public EllipseFigure()
        {
            listPoints = new List<Point>();

            painter = new EllipsePainter();
            calculator = new EllipseCalculator();
            checker = new EllipseChecker();
            mover = new EllipseMover();

        }
        public EllipseFigure(Pen pen)
        {
            listPoints = new List<Point>();
            this.pen = pen;

            painter = new EllipsePainter();
            calculator = new EllipseCalculator();
            checker = new EllipseChecker();
            mover = new EllipseMover();
        }
        public EllipseFigure(Color color, int width)
        {
            listPoints = new List<Point>();
            this.pen = new Pen(color, width);

            painter = new EllipsePainter();
            calculator = new EllipseCalculator();
            checker = new EllipseChecker();
            mover = new EllipseMover();
        }
    }
}
