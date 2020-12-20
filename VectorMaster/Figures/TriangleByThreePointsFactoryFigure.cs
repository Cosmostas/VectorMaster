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
    public class TriangleByThreePointsFactoryFigure : AFigure
    {
        public TriangleByThreePointsFactoryFigure()
        {
            listPoints = new List<Point>();

            checker = new PolygonChecker();
            painter = new PolygonPainter();
            calculator = new RightTriangleCalculator();

        }
        public TriangleByThreePointsFactoryFigure(Pen pen)
        {
            listPoints = new List<Point>();
            this.pen = pen;

            checker = new PolygonChecker();
            painter = new PolygonPainter();
            calculator = new RightTriangleCalculator();
        }
        public TriangleByThreePointsFactoryFigure(Color color, int width)
        {
            listPoints = new List<Point>();
            this.pen = new Pen(color, width);

            checker = new PolygonChecker();
            painter = new PolygonPainter();
            calculator = new RightTriangleCalculator();
        }
    }
}
