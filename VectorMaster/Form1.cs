using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VectorMaster.Factory;
using VectorMaster.MouseHandler;

namespace VectorMaster
{
    public partial class Form1 : Form
    {
        Canvas canvas = Canvas.CreateBitmap();

        public Form1()
        {
            InitializeComponent();
        }

   
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            canvas.prevPoint = e.Location;
            canvas.isMouseDown = true;

            canvas.MouseHandler.RealizeMouseDown();

            //switch (mode)
            //{
            //    case "Paint":
            //        currentFigure = factory.CreateFigure(pen);
            //        break;
            //    case "Brush":
            //        currentFigure = factory.CreateFigure(pen);
            //        break;
            //    case "Move":
            //        currentFigure = null;
            //        foreach (AFigure figure in figures)
            //        {
            //            if (figure.CheckHit(e.Location))
            //            {
            //                currentFigure = figure;
            //                figures.Remove(currentFigure);
            //                DrawAll();
            //                pen = figure.pen;
            //                break;
            //            }
            //        }
            //        break;
            //    case "MoveVertex":
            //        currentFigure = null;
            //        foreach (AFigure figure in figures)
            //        {
            //            if (figure.CheckHitInVertex(e.Location) != -1)
            //            {
            //                index = figure.CheckHitInVertex(e.Location);
            //                currentFigure = figure;
            //                figures.Remove(currentFigure);
            //                DrawAll();
            //                pen = figure.pen;
            //                break;
            //            }
            //        }
            //        break;
            //    case "AddPoint":
            //        currentFigure = null;
            //        foreach (AFigure figure in figures)
            //        {
            //            if (figure.CheckHit(e.Location))
            //            {
            //                SolidBrush redBrush = new SolidBrush(Color.Red);
            //                Graphics graphics;
            //                graphics = Graphics.FromImage(bitmapSingleton.bitmap);
            //                graphics.FillEllipse(redBrush, e.X, e.Y, pen.Width, pen.Width);
            //                currentFigure = figure;
            //                currentFigure.listPoints.Add(e.Location);
            //                figures.Remove(currentFigure);
            //                break;
            //            }
            //        }
            //        break;
            //    case "Rotate":
            //        currentFigure = null;
            //        foreach (AFigure figure in figures)
            //        {
            //            if (figure.CheckHit(e.Location))
            //            {
            //                currentFigure = figure;
            //                figures.Remove(currentFigure);
            //                DrawAll();
            //                pen = figure.pen;
            //                break;
            //            }
            //        }
            //        break;
            //}
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (canvas.isMouseDown && canvas.currentFigure != null)
            {

                Bitmap bitmap = (Bitmap)canvas.bitmap.Clone();

                canvas.MouseHandler.RealizeMouseMove(e.Location);    

            //    Point delta;
            //    switch (mode)
            //    {
            //        case "Paint":
            //            currentFigure.listPoints = currentFigure.Calculate(prevPoint, CalculatePoint(e.Location));
            //            currentFigure.Paint();
            //            break;
            //        case "Brush":
            //            currentFigure.listPoints.Add(prevPoint);
            //            currentFigure.listPoints.Add(e.Location);
            //            prevPoint = e.Location;
            //            break;
            //        case "Move":
            //            delta = new Point(e.Location.X - prevPoint.X, e.Location.Y - prevPoint.Y);
            //            currentFigure.Move(delta, currentFigure.listPoints);
            //            prevPoint = e.Location;
            //            currentFigure.Paint();
            //            break;
            //        case "MoveVertex":
            //            Point deltaRelocatable = new Point(e.Location.X - (currentFigure.listPoints[index]).X, e.Location.Y - (currentFigure.listPoints[index]).Y);
            //            currentFigure.MovePoint(index, deltaRelocatable);
            //            prevPoint = e.Location;
            //            break;
            //        case "Rotate":
            //            delta = new Point(e.Location.X - prevPoint.X, e.Location.Y - prevPoint.Y);
            //            currentFigure.Rotate(bitmap, delta);
            //            prevPoint = e.Location;
            //            break;
            //    }
                
                pictureBox1.Image = canvas.bitmap;
                canvas.bitmap = (Bitmap)bitmap.Clone();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //isMouseDown = false;

            //if(mode == "Paint")
            //{
            //    currentFigure.listPoints = currentFigure.Calculate(prevPoint, CalculatePoint(e.Location));
            //}
            //if(currentFigure != null)
            //{
            //    figures.Add(currentFigure);
            //    currentFigure.Paint();
            //    pictureBox1.Image = canvas.bitmap;
            //}



            //prevPoint = e.Location;

            //if (mode == "Pipete")
            //{
            //    pen.Color = canvas.bitmap.GetPixel(e.Location.X, e.Location.Y);
            //    mode = "Paint";
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canvas.bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Bitmap bitmap = (Bitmap)canvas.bitmap;

            canvas.pen = new Pen(colorDialog1.Color, trackBar1.Value);

            canvas.MouseHandler = new PaintMouseHandler();
            canvas.factory = new LineFactory();
        }

        

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            canvas.pen.Width = trackBar1.Value;
        }


        private void buttonPipette_Click(object sender, EventArgs e)
        {
            canvas.mode = "Pipete";
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                canvas.pen.Color = colorDialog1.Color;
            }
        }


        private void LineTools_Click(object sender, EventArgs e)
        {
            canvas.mode = "Paint";
            canvas.factory = new LineFactory();
        }

        private void RectangleTools_Click(object sender, EventArgs e)
        {
            canvas.mode = "Paint";
            canvas.factory = new RectangleFactory();
        }

        private void EllipseTools_Click(object sender, EventArgs e)
        {
            canvas.mode = "Paint";
            canvas.factory = new EllipseFactory();
        }

        private void RhombusTools_Click(object sender, EventArgs e)
        {
            canvas.mode = "Paint";
            canvas.factory = new RhombusFactory();
        }

        private void IsoscelesTriangleTools_Click(object sender, EventArgs e)
        {
            canvas.mode = "Paint";
            canvas.factory = new IsoscelesTriangleFactory();
        }

        private void RightTriangleTools_Click(object sender, EventArgs e)
        {
            canvas.mode = "Paint";
            canvas.factory = new RightTriangleFactory();
        }

        private void BrokenLineTools_Click(object sender, EventArgs e)
        {
            canvas.mode = "Paint";
            canvas.factory = new LineFactory();
        }

        private void EraserTriangle_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)canvas.bitmap.Clone();
            canvas.figures.Clear();
            Graphics graphics;
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);

            pictureBox1.Image = bitmap;
        }

        private void BrushTools_Click(object sender, EventArgs e)
        {
            canvas.mode = "Brush";

            canvas.factory = new BrushFactory();
        }

        public void DrawAll()
        {
            Bitmap bitmap = (Bitmap)canvas.bitmap.Clone();
            Graphics graphics;
            graphics = Graphics.FromImage(bitmap);

            foreach (AFigure figure in canvas.figures)
            {
                figure.Paint();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(canvas.mode == "Move")
            {
                canvas.mode = "Paint";
            }
            else
            {
                canvas.mode = "Move";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (canvas.mode == "Rotate")
            {
                canvas.mode = "Paint";
            }
            else
            {
                canvas.mode = "Rotate";

            }
        }

        private void buttonMoveVertex_Click(object sender, EventArgs e)
        {
            if (canvas.mode == "MoveVertex")
            {
                canvas.mode = "Paint";
            }
            else
            {
                canvas.mode = "MoveVertex";

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            canvas.mode = "Paint";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            canvas.mode = "Move";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            canvas.mode = "MoveVertex";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            canvas.mode = "AddPoint";
        }

        
    }
}
