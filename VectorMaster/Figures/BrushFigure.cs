using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorMaster.Calculators;
using VectorMaster.Checkers;
using VectorMaster.Movers;
using VectorMaster.Painters;

namespace VectorMaster.Figures
{
    public class BrushFigure : AFigure
    {
        public BrushFigure()
        {
            points = new List<Point>();

            painter = new BrushPainter();
            mover = new PolygonMover();
            checker = new PolygonChecker();
        }
        public BrushFigure(Pen pen)
        {
            points = new List<Point>();
            this.pen = pen;

            painter = new BrushPainter();
            mover = new PolygonMover();
            checker = new PolygonChecker();

        }
        public BrushFigure(Color color, int width)
        {
            points = new List<Point>();
            this.pen = new Pen(color, width);

            painter = new BrushPainter();
            mover = new PolygonMover();
            checker = new PolygonChecker();
        }
    }
}
