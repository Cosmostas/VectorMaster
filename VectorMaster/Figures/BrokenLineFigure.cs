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
    public class BrokenLineFigure : AFigure
    {
        public BrokenLineFigure()
        {
            listPoints = new List<Point>();

            painter = new LinePainter();
            calculator = new BrokenLineCalculator();

        }
        public BrokenLineFigure(Pen pen)
        {
            listPoints = new List<Point>();
            this.pen = pen;

            painter = new LinePainter();
            calculator = new BrokenLineCalculator();
        }
        public BrokenLineFigure(Color color, int width)
        {
            listPoints = new List<Point>();
            this.pen = new Pen(color, width);

            painter = new LinePainter();
            calculator = new BrokenLineCalculator();
        }
    }
}
