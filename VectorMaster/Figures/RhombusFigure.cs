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
    public class RhombusFigure : AFigure
    {
        public RhombusFigure()
        {
            listPoints = new List<Point>();

            painter = new PolygonPainter();
            calculator = new RhombusCalculator();
            mover = new PolygonMover();
            moverVertex = new PolygonMover();
            checker = new PolygonChecker();
            checkerInVertex = new PolygonChecker();

        }
        public RhombusFigure(Pen pen)
        {
            listPoints = new List<Point>();
            this.pen = pen;

            painter = new PolygonPainter();
            calculator = new RhombusCalculator();
            mover = new PolygonMover();
            moverVertex = new PolygonMover();
            checker = new PolygonChecker();
            checkerInVertex = new PolygonChecker();
        }
        public RhombusFigure(Color color, int width)
        {
            listPoints = new List<Point>();
            this.pen = new Pen(color, width);

            painter = new PolygonPainter();
            calculator = new RhombusCalculator();
            mover = new PolygonMover();
            moverVertex = new PolygonMover();
            checker = new PolygonChecker();
            checkerInVertex = new PolygonChecker();
        }
    }
}
