using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.MouseHandler
{
    public class ResizerMouseHandler : IMouseHandler
    {
        public void RealizeMouseDown()
        {
            Canvas canvas = Canvas.CreateCanvas();
            canvas.currentFigure = null;
            Bitmap bitmap = (Bitmap)canvas.bitmap.Clone();
            Graphics graphics = Graphics.FromImage(bitmap);
            SolidBrush redBrush = new SolidBrush(Color.Red);

            foreach (AFigure figure in canvas.figures)
            {
                if (figure.CheckHit(canvas.curPoint) != null)
                {
                    canvas.currentFigure = figure;
                    Point midpoint = canvas.currentFigure.MidpointCalculate();
                    //canvas.currentFigure.listPoints.Add(midpoint);
                    graphics.FillEllipse(redBrush, midpoint.X, midpoint.Y, 5, 5);
                    canvas.figures.Remove(canvas.currentFigure);
                    canvas.DrawAll();
                    canvas.pen = figure.pen;
                    break;
                }
            }
        }

        public void RealizeMouseMove()
        {
            Canvas canvas = Canvas.CreateCanvas();
            Bitmap bitmap = (Bitmap)canvas.bitmap.Clone();
            Graphics graphics = Graphics.FromImage(bitmap);
            SolidBrush redBrush = new SolidBrush(Color.Red);

            if (canvas.currentFigure != null && canvas.isMouseDown)
            {
                Point midpoint = canvas.currentFigure.MidpointCalculate();
                graphics.FillEllipse(redBrush, midpoint.X, midpoint.Y, 5, 5);
                
                if(canvas.currentFigure.CheckHitInVertex(canvas.currentFigure.listPoints[canvas.currentFigure.listPoints.Count-1]) != -1)
                {
                    Point delta = new Point(canvas.curPoint.X - canvas.currentFigure.listPoints[canvas.currentFigure.listPoints.Count - 1].X, canvas.curPoint.Y - canvas.currentFigure.listPoints[canvas.currentFigure.listPoints.Count - 1].Y);
                    canvas.currentFigure.Move(delta, canvas.currentFigure.listPoints);
                }

                /*for (int i = 0; i < canvas.currentFigure.listPoints.Count; i++)
                {
                if (canvas.curPoint.X > midpoint.X && canvas.curPoint.Y < midpoint.Y)
                {
                    if (canvas.currentFigure.listPoints[i].X >= midpoint.X && canvas.currentFigure.listPoints[i].Y <= midpoint.Y)
                    {
                        Point deltaOne = new Point(canvas.curPoint.X - canvas.prevPoint.X, canvas.curPoint.Y - canvas.prevPoint.Y);
                        canvas.currentFigure.Move(i, deltaOne, canvas.currentFigure.listPoints);
                    }
                    else if (canvas.currentFigure.listPoints[i].X >= midpoint.X && canvas.currentFigure.listPoints[i].Y >= midpoint.Y)
                    {
                        Point deltaTwo = new Point(canvas.curPoint.X - canvas.prevPoint.X, 0);
                        canvas.currentFigure.Move(i, deltaTwo, canvas.currentFigure.listPoints);
                    }
                    else if (canvas.currentFigure.listPoints[i].X <= midpoint.X && canvas.currentFigure.listPoints[i].Y <= midpoint.Y)
                    {
                        Point deltaThree = new Point(0, canvas.curPoint.Y - canvas.prevPoint.Y);
                        canvas.currentFigure.Move(i, deltaThree, canvas.currentFigure.listPoints);
                    }
                }
                else if (canvas.curPoint.X < midpoint.X && canvas.curPoint.Y < midpoint.Y)
                {
                    if (canvas.currentFigure.listPoints[i].X <= midpoint.X && canvas.currentFigure.listPoints[i].Y <= midpoint.Y)
                    {
                        Point deltaOne = new Point(canvas.curPoint.X - canvas.prevPoint.X, canvas.curPoint.Y - canvas.prevPoint.Y);
                        canvas.currentFigure.Move(i, deltaOne, canvas.currentFigure.listPoints);
                    }
                    else if (canvas.currentFigure.listPoints[i].X >= midpoint.X && canvas.currentFigure.listPoints[i].Y <= midpoint.Y)
                    {
                        Point deltaTwo = new Point(0, canvas.curPoint.Y - canvas.prevPoint.Y);
                        canvas.currentFigure.Move(i, deltaTwo, canvas.currentFigure.listPoints);
                    }
                    else if (canvas.currentFigure.listPoints[i].X <= midpoint.X && canvas.currentFigure.listPoints[i].Y >= midpoint.Y)
                    {
                        Point deltaThree = new Point(canvas.curPoint.X - canvas.prevPoint.X, 0);
                        canvas.currentFigure.Move(i, deltaThree, canvas.currentFigure.listPoints);
                    }
                }
                else if (canvas.curPoint.X < midpoint.X && canvas.curPoint.Y > midpoint.Y)
                {
                    if (canvas.currentFigure.listPoints[i].X <= midpoint.X && canvas.currentFigure.listPoints[i].Y >= midpoint.Y)
                    {
                        Point deltaOne = new Point(canvas.curPoint.X - canvas.prevPoint.X, canvas.curPoint.Y - canvas.prevPoint.Y);
                        canvas.currentFigure.Move(i, deltaOne, canvas.currentFigure.listPoints);
                    }
                    else if (canvas.currentFigure.listPoints[i].X >= midpoint.X && canvas.currentFigure.listPoints[i].Y >= midpoint.Y)
                    {
                        Point deltaTwo = new Point(0, canvas.curPoint.Y - canvas.prevPoint.Y);
                        canvas.currentFigure.Move(i, deltaTwo, canvas.currentFigure.listPoints);
                    }
                    else if (canvas.currentFigure.listPoints[i].X <= midpoint.X && canvas.currentFigure.listPoints[i].Y <= midpoint.Y)
                    {
                        Point deltaThree = new Point(canvas.curPoint.X - canvas.prevPoint.X, 0);
                        canvas.currentFigure.Move(i, deltaThree, canvas.currentFigure.listPoints);
                    }
                }
                else if (canvas.curPoint.X > midpoint.X && canvas.curPoint.Y > midpoint.Y)
                {
                    if (canvas.currentFigure.listPoints[i].X >= midpoint.X && canvas.currentFigure.listPoints[i].Y >= midpoint.Y)
                    {
                        Point deltaOne = new Point(canvas.curPoint.X - canvas.prevPoint.X, canvas.curPoint.Y - canvas.prevPoint.Y);
                        canvas.currentFigure.Move(i, deltaOne, canvas.currentFigure.listPoints);
                    }
                    else if (canvas.currentFigure.listPoints[i].X >= midpoint.X && canvas.currentFigure.listPoints[i].Y <= midpoint.Y)
                    {
                        Point deltaTwo = new Point(canvas.curPoint.X - canvas.prevPoint.X, 0);
                        canvas.currentFigure.Move(i, deltaTwo, canvas.currentFigure.listPoints);
                    }
                    else if (canvas.currentFigure.listPoints[i].X <= midpoint.X && canvas.currentFigure.listPoints[i].Y >= midpoint.Y)
                    {
                        Point deltaThree = new Point(0, canvas.curPoint.Y - canvas.prevPoint.Y);
                        canvas.currentFigure.Move(i, deltaThree, canvas.currentFigure.listPoints);
                    }
                }

            }*/
            canvas.currentFigure.Paint();
        }

            canvas.prevPoint = canvas.curPoint;
            canvas.pictureBox.Image = canvas.bitmap;
            canvas.bitmap = (Bitmap)bitmap.Clone();
              
        }

        public void RealizeMouseup()
        {
            Canvas canvas = Canvas.CreateCanvas();

            if (canvas.currentFigure != null)
            {
                canvas.figures.Add(canvas.currentFigure);
                canvas.currentFigure.Paint();

            }

            canvas.prevPoint = canvas.curPoint;
        }
    }
}
