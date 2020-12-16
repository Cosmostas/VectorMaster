using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorMaster.Calculators;

namespace VectorMaster.Figures
{
    public class IsoscelesTriangleFigure : AFigure
    {
        public IsoscelesTriangleFigure()
        {
            listPoints = new List<Point>();

            painter = new LinePainter();
            calculator = new IsoscelesTriangleCalculator();

        }
        public IsoscelesTriangleFigure(Pen pen)
        {
            listPoints = new List<Point>();
            this.pen = pen;

            painter = new LinePainter();
            calculator = new IsoscelesTriangleCalculator();
        }
        public IsoscelesTriangleFigure(Color color, int width)
        {
            listPoints = new List<Point>();
            this.pen = new Pen(color, width);

            painter = new LinePainter();
            calculator = new IsoscelesTriangleCalculator();
        }
    }
}
