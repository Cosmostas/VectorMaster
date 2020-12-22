using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorMaster.Calculators;
using VectorMaster.Movers;
using VectorMaster.Checkers;

namespace VectorMaster
{
    public class IsoscelesTriangleTestFigure : AFigure
    {
        public IsoscelesTriangleTestFigure()
        {
            points = new List<Point>();

            painter = new PolygonPainter();
            calculator = new RectangleCalculator();
            mover = new PolygonMover();
            checker = new PolygonChecker();
            checkerInVertex = new PolygonChecker();

        }
        public IsoscelesTriangleTestFigure(Pen pen)
        {
            points = new List<Point>();
            this.pen = pen;

            painter = new PolygonPainter();
            calculator = new RectangleCalculator();
            mover = new PolygonMover();
            checker = new PolygonChecker();
        }
        public IsoscelesTriangleTestFigure(Color color, int width)
        {
            points = new List<Point>();
            this.pen = new Pen(color, width);

            painter = new PolygonPainter();
            calculator = new RectangleCalculator();
            mover = new PolygonMover();
            checker = new PolygonChecker();
        }

    }
}
