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
        int midpointX;
        int midpointY;
        int maxValueX;
        int maxValueY;
        int minValueX;
        int minValueY;

        public void RealizeMouseDown()
        {
            Canvas canvas = Canvas.CreateCanvas();
            canvas.currentFigure = null;

            foreach (AFigure figure in canvas.figures)
            {
                if (figure.CheckHit(canvas.curPoint) != null)
                {
                    canvas.currentFigure = figure;
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

                if (canvas.currentFigure != null && canvas.isMouseDown)
                {
                    maxValueX = canvas.currentFigure.listPoints[0].X;

                    for (int i = 0; i < canvas.currentFigure.listPoints.Count; i++)
                    {
                        if (maxValueX < canvas.currentFigure.listPoints[i].X)
                        {
                            maxValueX = canvas.currentFigure.listPoints[i].X;
                        }
                    }

                    maxValueY = canvas.currentFigure.listPoints[0].Y;

                    for (int i = 0; i < canvas.currentFigure.listPoints.Count; i++)
                    {
                        if (maxValueY < canvas.currentFigure.listPoints[i].Y)
                        {
                            maxValueY = canvas.currentFigure.listPoints[i].Y;
                        }
                    }

                    minValueX = canvas.currentFigure.listPoints[0].X;

                    for (int i = 0; i < canvas.currentFigure.listPoints.Count; i++)
                    {
                        if (minValueX > canvas.currentFigure.listPoints[i].X)
                        {
                            minValueX = canvas.currentFigure.listPoints[i].X;
                        }
                    }

                    minValueY = canvas.currentFigure.listPoints[0].Y;

                    for (int i = 0; i < canvas.currentFigure.listPoints.Count; i++)
                    {
                        if (minValueY > canvas.currentFigure.listPoints[i].Y)
                        {
                            minValueY = canvas.currentFigure.listPoints[i].Y;
                        }
                    }

                    midpointX = (maxValueX - minValueX) / 2 + minValueX;
                    midpointY = (maxValueY - minValueY) / 2 + minValueY;

                for(int i = 0; i < canvas.currentFigure.listPoints.Count; i++)
                {
                    if (canvas.curPoint.X > midpointX && canvas.curPoint.Y < midpointY)
                    {
                        if (canvas.currentFigure.listPoints[i].X >= midpointX && canvas.currentFigure.listPoints[i].Y <= midpointY)
                        {
                            Point deltaOne = new Point(canvas.curPoint.X - canvas.prevPoint.X, canvas.curPoint.Y - canvas.prevPoint.Y);
                            canvas.currentFigure.Move(i, deltaOne, canvas.currentFigure.listPoints);
                        }
                        else if (canvas.currentFigure.listPoints[i].X >= midpointX && canvas.currentFigure.listPoints[i].Y >= midpointY)
                        {
                            Point deltaTwo = new Point(canvas.curPoint.X - canvas.prevPoint.X, 0);
                            canvas.currentFigure.Move(i, deltaTwo, canvas.currentFigure.listPoints);
                        }
                        else if (canvas.currentFigure.listPoints[i].X <= midpointX && canvas.currentFigure.listPoints[i].Y <= midpointY)
                        {
                            Point deltaThree = new Point(0, canvas.curPoint.Y - canvas.prevPoint.Y);
                            canvas.currentFigure.Move(i, deltaThree, canvas.currentFigure.listPoints);
                        }
                    }
                    else if (canvas.curPoint.X < midpointX && canvas.curPoint.Y < midpointY)
                    {
                        if (canvas.currentFigure.listPoints[i].X <= midpointX && canvas.currentFigure.listPoints[i].Y <= midpointY)
                        {
                            Point deltaOne = new Point(canvas.curPoint.X - canvas.prevPoint.X, canvas.curPoint.Y - canvas.prevPoint.Y);
                            canvas.currentFigure.Move(i, deltaOne, canvas.currentFigure.listPoints);
                        }
                        else if (canvas.currentFigure.listPoints[i].X >= midpointX && canvas.currentFigure.listPoints[i].Y <= midpointY)
                        {
                            Point deltaTwo = new Point(0, canvas.curPoint.Y - canvas.prevPoint.Y);
                            canvas.currentFigure.Move(i, deltaTwo, canvas.currentFigure.listPoints);
                        }
                        else if (canvas.currentFigure.listPoints[i].X <= midpointX && canvas.currentFigure.listPoints[i].Y >= midpointY)
                        {
                            Point deltaThree = new Point(canvas.curPoint.X - canvas.prevPoint.X, 0);
                            canvas.currentFigure.Move(i, deltaThree, canvas.currentFigure.listPoints);
                        }
                    }
                    else if (canvas.curPoint.X < midpointX && canvas.curPoint.Y > midpointY)
                    {
                        if (canvas.currentFigure.listPoints[i].X <= midpointX && canvas.currentFigure.listPoints[i].Y >= midpointY)
                        {
                            Point deltaOne = new Point(canvas.curPoint.X - canvas.prevPoint.X, canvas.curPoint.Y - canvas.prevPoint.Y);
                            canvas.currentFigure.Move(i, deltaOne, canvas.currentFigure.listPoints);
                        }
                        else if (canvas.currentFigure.listPoints[i].X >= midpointX && canvas.currentFigure.listPoints[i].Y >= midpointY)
                        {
                            Point deltaTwo = new Point(0, canvas.curPoint.Y - canvas.prevPoint.Y);
                            canvas.currentFigure.Move(i, deltaTwo, canvas.currentFigure.listPoints);
                        }
                        else if (canvas.currentFigure.listPoints[i].X <= midpointX && canvas.currentFigure.listPoints[i].Y <= midpointY)
                        {
                            Point deltaThree = new Point(canvas.curPoint.X - canvas.prevPoint.X, 0);
                            canvas.currentFigure.Move(i, deltaThree, canvas.currentFigure.listPoints);
                        }
                    }
                    else if (canvas.curPoint.X > midpointX && canvas.curPoint.Y > midpointY)
                    {
                        if (canvas.currentFigure.listPoints[i].X >= midpointX && canvas.currentFigure.listPoints[i].Y >= midpointY)
                        {
                            Point deltaOne = new Point(canvas.curPoint.X - canvas.prevPoint.X, canvas.curPoint.Y - canvas.prevPoint.Y);
                            canvas.currentFigure.Move(i, deltaOne, canvas.currentFigure.listPoints);
                        }
                        else if (canvas.currentFigure.listPoints[i].X >= midpointX && canvas.currentFigure.listPoints[i].Y <= midpointY)
                        {
                            Point deltaTwo = new Point(canvas.curPoint.X - canvas.prevPoint.X, 0);
                            canvas.currentFigure.Move(i, deltaTwo, canvas.currentFigure.listPoints);
                        }
                        else if (canvas.currentFigure.listPoints[i].X <= midpointX && canvas.currentFigure.listPoints[i].Y >= midpointY)
                        {
                            Point deltaThree = new Point(0, canvas.curPoint.Y - canvas.prevPoint.Y);
                            canvas.currentFigure.Move(i, deltaThree, canvas.currentFigure.listPoints);
                        }
                    }

                }
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
