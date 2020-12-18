﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorMaster.Calculators;
using VectorMaster.Movers;

namespace VectorMaster
{
    public class RectangleFigure : AFigure
    {
        public RectangleFigure()
        {
            listPoints = new List<Point>();

            painter = new PolygonPainter();
            calculator = new RectangleCalculator();
            mover = new RectangleMover();

        }
        public RectangleFigure(Pen pen)
        {
            listPoints = new List<Point>();
            this.pen = pen;

            painter = new PolygonPainter();
            calculator = new RectangleCalculator();
            mover = new RectangleMover();
        }
        public RectangleFigure(Color color, int width)
        {
            listPoints = new List<Point>();
            this.pen = new Pen(color, width);

            painter = new PolygonPainter();
            calculator = new RectangleCalculator();
            mover = new RectangleMover();
        }

    }
}
