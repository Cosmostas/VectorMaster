using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VectorMaster.Movers;
using VectorMaster.Calculators;
using VectorMaster.Checkers;
using VectorMaster.Rotators;

namespace VectorMaster
{
    public abstract class AFigure
    {

        public List<Point> listPoints { get; set; }
        public Pen pen { get; set; }

        protected IPainter painter;
        protected IMover mover;
        protected IMover moverVertex;
        protected ICalculator calculator;
        protected IChecker checker;
        protected IRotator rotator;
        protected IChecker checkerInVertex;

        public void Paint()
        {
            painter.Paint(pen, listPoints);
        }

        //public void PaintDots()
        //{
        //    painter.PaintDots(pen, listPoints);
        //}

        public void Move(Point delta, List<Point> listPoints)
        {
            mover.Move(delta, listPoints);
        }
        public void MovePoints(Point delta, List<Point> listPoints)
        {
            mover.MovePoints(delta, listPoints);
        }


        public List<Point> Calculate(Point firstPoint, Point lastPoint)
        {
            return calculator.Calculate(firstPoint, lastPoint);
        }

        public List<Point> CheckHit(Point dot)
        {
            return checker.CheckHit(dot, listPoints, (int)pen.Width);
     
        }
        public void Rotate(Bitmap Bm, Point delta)
        {


        }

        public int CheckHitInVertex(Point dot)
        {
            return checkerInVertex.CheckHitInVertex(dot, listPoints);
        }
        
    }
}
