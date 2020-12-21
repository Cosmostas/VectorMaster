using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.MouseHandler
{
    public class BrokenLineMouseHandler : IMouseHandler
    {
        bool isPaintingNow = false;
        public void RealizeMouseDown()
        {

            Canvas canvas = Canvas.CreateCanvas();
            if (!isPaintingNow)
            {
                canvas.currentFigure = canvas.factory.CreateFigure(canvas.pen);

                isPaintingNow = true;

                canvas.currentFigure.listPoints = canvas.currentFigure.Calculate(canvas.prevPoint, canvas.CalculatePoint(canvas.curPoint));
            }
            if (canvas.curPoint == canvas.prevPoint)
            {
                isPaintingNow = false;
                canvas.currentFigure.Paint();
                canvas.currentFigure.listPoints = canvas.currentFigure.Calculate(canvas.prevPoint, canvas.CalculatePoint(canvas.curPoint));
                return;
            }



        }

        public void RealizeMouseMove()
        {
            if (isPaintingNow)
            {
                Canvas canvas = Canvas.CreateCanvas();
                Bitmap bitmap = (Bitmap)canvas.bitmap.Clone();

                if(canvas.currentFigure != null)
                {
                    List <Point> figurePoints = canvas.currentFigure.listPoints;
                    canvas.currentFigure.listPoints = canvas.currentFigure.Calculate(canvas.prevPoint, canvas.CalculatePoint(canvas.curPoint));
                    canvas.currentFigure.Paint();
                    canvas.currentFigure.listPoints = figurePoints;
                }

                canvas.pictureBox.Image = canvas.bitmap;
                canvas.bitmap = (Bitmap) bitmap.Clone();

            }


            }

        public void RealizeMouseup()
        {
            if (isPaintingNow)
            {
                Canvas canvas = Canvas.CreateCanvas();

                canvas.prevPoint = canvas.curPoint;

                canvas.currentFigure.Paint();
                canvas.currentFigure.listPoints = canvas.currentFigure.Calculate(canvas.prevPoint, canvas.CalculatePoint(canvas.curPoint));

            }
        }
    }
}



// if (canvas.isMouseDown && canvas.currentFigure != null)
//            {

//                Bitmap bitmap = (Bitmap)canvas.bitmap.Clone();

//canvas.MouseHandler.RealizeMouseMove();

//                //    Point delta;
//                //    switch (mode)
//                //    {
//                //        case "Paint":
//                //            currentFigure.listPoints = currentFigure.Calculate(prevPoint, CalculatePoint(e.Location));
//                //            currentFigure.Paint();
//                //            break;
//                //        case "Brush":
//                //            currentFigure.listPoints.Add(prevPoint);
//                //            currentFigure.listPoints.Add(e.Location);
//                //            prevPoint = e.Location;
//                //            break;
//                //        case "Move":
//                //            delta = new Point(e.Location.X - prevPoint.X, e.Location.Y - prevPoint.Y);
//                //            currentFigure.Move(delta, currentFigure.listPoints);
//                //            prevPoint = e.Location;
//                //            currentFigure.Paint();
//                //            break;
//                //        case "MoveVertex":
//                //            Point deltaRelocatable = new Point(e.Location.X - (currentFigure.listPoints[index]).X, e.Location.Y - (currentFigure.listPoints[index]).Y);
//                //            currentFigure.MovePoint(index, deltaRelocatable);
//                //            prevPoint = e.Location;
//                //            break;
//                //        case "Rotate":
//                //            delta = new Point(e.Location.X - prevPoint.X, e.Location.Y - prevPoint.Y);
//                //            currentFigure.Rotate(bitmap, delta);
//                //            prevPoint = e.Location;
//                //            break;
//                //    }

//                pictureBox1.Image = canvas.bitmap;

//                canvas.bitmap = (Bitmap) bitmap.Clone();
//            }