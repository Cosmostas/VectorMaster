using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorMaster.Calculators;
using VectorMaster.Checkers;

namespace VectorMaster.Figures
{
    public class RightTriangleFigure : AFigure
    {
        public RightTriangleFigure()
        {
            listPoints = new List<Point>();

            checker = new PolygonChecker();
            painter = new PolygonPainter();
            calculator = new RightTriangleCalculator();

        }
        public RightTriangleFigure(Pen pen)
        {
            listPoints = new List<Point>();
            this.pen = pen;

            checker = new PolygonChecker();
            painter = new PolygonPainter();
            calculator = new RightTriangleCalculator();
        }
        public RightTriangleFigure(Color color, int width)
        {
            listPoints = new List<Point>();
            this.pen = new Pen(color, width);

            checker = new PolygonChecker();
            painter = new PolygonPainter();
            calculator = new RightTriangleCalculator();
        }
    }
}
