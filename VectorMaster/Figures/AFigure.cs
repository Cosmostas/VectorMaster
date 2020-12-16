using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VectorMaster.Movers;
using VectorMaster.Calculators;
using VectorMaster.Checkers;

namespace VectorMaster
{
    public abstract class AFigure
    {

        public List<Point> listPoints { get; set; }
        public Pen pen { get; set; }

        protected IPainter painter;
        protected IMover mover;
        protected ICalculator calculator;
        protected IChecker checker;

        public void Paint(Bitmap Bm)
        {
            painter.Paint(Bm, pen, listPoints);
        }
        public void Move(Point delta)
        {
            mover.Move(delta);
        }
        public List<Point> Calculate(Point firstPoint, Point lastPoint)
        {
            return calculator.Calculate(firstPoint, lastPoint);
        }
        public bool CheckHit(Point dot)
        {
            return checker.CheckHit(dot, listPoints);
        }
    }
}
