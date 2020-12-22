using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorMaster.Calculators;
using VectorMaster.Checkers;
using VectorMaster.Movers;

namespace VectorMaster.Figures
{
    public class RightTriangleFigure : AFigure
    {
        public RightTriangleFigure()
        {
            points = new List<Point>();

            painter = new PolygonPainter();
            calculator = new RightTriangleCalculator();
            mover = new PolygonMover();
            mover = new PolygonMover();
            checker = new PolygonChecker();

        }
        public RightTriangleFigure(Pen pen)
        {
            points = new List<Point>();
            this.pen = pen;

            painter = new PolygonPainter();
            calculator = new RightTriangleCalculator();
            mover = new PolygonMover();
            mover = new PolygonMover();
            checker = new PolygonChecker();
        }
        public RightTriangleFigure(Color color, int width)
        {
            points = new List<Point>();
            this.pen = new Pen(color, width);

            painter = new PolygonPainter();
            calculator = new RightTriangleCalculator();
            mover = new PolygonMover();
            mover = new PolygonMover();
            checker = new PolygonChecker();
        }
    }
}
