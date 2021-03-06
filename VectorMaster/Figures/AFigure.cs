﻿using System;
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

        public List<Point> points { get; set; }
        public Pen pen { get; set; }

        public Point center;

        protected IPainter painter;
        protected IMover mover;
        protected IMover moverVertex;
        protected ICalculator calculator;
        protected IChecker checker;
        protected IChecker checkerInVertex;

        public void Paint()
        {
            painter.Paint(pen, points);
        }
        public void PaintDots()
        {
            painter.PaintDots(pen, points);
        }
        public void Move(Point delta, List<Point> listPoints)
        {
            mover.Move(delta, listPoints);
        }
        public void MovePoints(Point delta, List<Point> listPoints)
        {
            mover.MovePoints(delta, listPoints);
        }


        public List<Point> Calculate()
        {
            return calculator.Calculate();
        } 
        public Point CalculateCenter()
        {
            return calculator.CalculateCenter();
        }

        public List<Point> CheckHit(Point dot)
        {
            return checker.CheckHit(dot, points, (int)pen.Width);
     
        }
        public void Rotate(Bitmap Bm, Point delta)
        {


        }
        
    }
}
