﻿using System;
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
    public class BrokenLineFigure : AFigure
    {
        public BrokenLineFigure()
        {
            points = new List<Point>();

            painter = new BrokenLinePainter();
            calculator = new BrokenLineCalculator();
            mover = new PolygonMover();
            checker = new PolygonChecker();
        }
        public BrokenLineFigure(Pen pen)
        {
            points = new List<Point>();
            this.pen = pen;

            painter = new BrokenLinePainter();
            calculator = new BrokenLineCalculator();
            mover = new PolygonMover();
            checker = new PolygonChecker();
        }
        public BrokenLineFigure(Color color, int width)
        {
            points = new List<Point>();
            this.pen = new Pen(color, width);

            painter = new BrokenLinePainter();
            calculator = new BrokenLineCalculator();
            mover = new PolygonMover();
            checker = new PolygonChecker();
        }
    }
}
