using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorMaster.Calculators;
using VectorMaster.Painters;

namespace VectorMaster.Figures
{
    public class EllipseFigure : AFigure
    {
        public EllipseFigure()
        {
            listPoints = new List<Point>();

            painter = new EllipsePainter();
            calculator = new EllipseCalculator();

        }
        public EllipseFigure(Pen pen)
        {
            listPoints = new List<Point>();
            this.pen = pen;

            painter = new EllipsePainter();
            calculator = new EllipseCalculator();
        }
        public EllipseFigure(Color color, int width)
        {
            listPoints = new List<Point>();
            this.pen = new Pen(color, width);

            painter = new EllipsePainter();
            calculator = new EllipseCalculator();
        }
    }
}
