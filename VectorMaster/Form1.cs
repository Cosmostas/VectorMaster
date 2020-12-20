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

namespace VectorMaster
{
    public partial class Form1 : Form
    {
        BitmapSingleton bitmapSingleton = BitmapSingleton.CreateBitmap();
        Pen pen;

        List<AFigure> figures = new List<AFigure>();

        AFigure currentFigure;
        
        IFactory factory;
        
        bool isMouseDown = false;

        Point prevPoint = new Point(0,0);

        String mode;

        int index;

        public Form1()
        {
            InitializeComponent();
        }

        public Point CalculatePoint(Point mouseLocation)
        {

            if (Control.ModifierKeys == Keys.Shift)
            {
                if (Math.Abs(mouseLocation.X - prevPoint.X) > Math.Abs(mouseLocation.Y - prevPoint.Y))
                {
                    if (mouseLocation.X - prevPoint.X > 0)
                    {
                        mouseLocation.X = prevPoint.X + Math.Abs(mouseLocation.Y - prevPoint.Y);
                    }
                    else
                    {
                        mouseLocation.X = prevPoint.X - Math.Abs(mouseLocation.Y - prevPoint.Y);
                    }

                }
                else
                {
                    if (mouseLocation.Y - prevPoint.Y > 0)
                    {
                        mouseLocation.Y = prevPoint.Y + Math.Abs(mouseLocation.X - prevPoint.X);
                    }
                    else
                    {
                        mouseLocation.Y = prevPoint.Y - Math.Abs(mouseLocation.X - prevPoint.X);
                    }
                }
            }

            return mouseLocation;
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            prevPoint = e.Location;
            isMouseDown = true;

            switch (mode)
            {
                case "Paint":
                    currentFigure = factory.CreateFigure(pen);
                    break;
                case "Brush":
                    currentFigure = factory.CreateFigure(pen);
                    break;
                case "Move":
                    currentFigure = null;
                    foreach (AFigure figure in figures)
                    {
                        if (figure.CheckHit(e.Location))
                        {
                            currentFigure = figure;
                            figures.Remove(currentFigure);
                            DrawAll();
                            pen = figure.pen;
                            break;
                        }
                    }
                    break;
                case "MoveVertex":
                    currentFigure = null;
                    foreach (AFigure figure in figures)
                    {
                        if (figure.CheckHitInVertex(e.Location) != -1)
                        {
                            index = figure.CheckHitInVertex(e.Location);
                            currentFigure = figure;
                            figures.Remove(currentFigure);
                            DrawAll();
                            pen = figure.pen;
                            break;
                        }
                    }
                    break;
                case "AddPoint":
                    currentFigure = null;
                    foreach (AFigure figure in figures)
                    {
                        if (figure.CheckHit(e.Location))
                        {
                            SolidBrush redBrush = new SolidBrush(Color.Red);
                            graphics = Graphics.FromImage(Bm);
                            graphics.FillEllipse(redBrush, e.X, e.Y, pen.Width, pen.Width);
                            currentFigure = figure;
                            currentFigure.listPoints.Add(e.Location);
                            figures.Remove(currentFigure);
                            break;
                        }
                    }
                    break;
                case "Rotate":
                    currentFigure = null;
                    foreach (AFigure figure in figures)
                    {
                        if (figure.CheckHit(e.Location))
                        {
                            currentFigure = figure;
                            figures.Remove(currentFigure);
                            DrawAll();
                            pen = figure.pen;
                            break;
                        }
                    }
                    break;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown && currentFigure != null)
            {

                Bitmap bitmap = (Bitmap)bitmapSingleton.bitmap.Clone();

                Point delta;
                switch (mode)
                {
                    case "Paint":
                        currentFigure.listPoints = currentFigure.Calculate(prevPoint, CalculatePoint(e.Location));
                        currentFigure.Paint();
                        break;
                    case "Brush":
                        currentFigure.listPoints.Add(prevPoint);
                        currentFigure.listPoints.Add(e.Location);
                        prevPoint = e.Location;
                        break;
                    case "Move":
                        delta = new Point(e.Location.X - prevPoint.X, e.Location.Y - prevPoint.Y);
                        currentFigure.Move(delta, currentFigure.listPoints);
                        prevPoint = e.Location;
                        currentFigure.Paint();
                        break;
                    case "MoveVertex":
                        Point deltaRelocatable = new Point(e.Location.X - (currentFigure.listPoints[index]).X, e.Location.Y - (currentFigure.listPoints[index]).Y);
                        currentFigure.MovePoint(index, deltaRelocatable);
                        prevPoint = e.Location;
                        break;
                    case "Rotate":
                        delta = new Point(e.Location.X - prevPoint.X, e.Location.Y - prevPoint.Y);
                        currentFigure.Rotate(bitmap, delta);
                        prevPoint = e.Location;
                        break;
                }
                
                pictureBox1.Image = bitmapSingleton.bitmap;
                bitmapSingleton.bitmap = (Bitmap)bitmap.Clone();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;

            if(mode == "Paint")
            {
                currentFigure.listPoints = currentFigure.Calculate(prevPoint, CalculatePoint(e.Location));
            }
            if(currentFigure != null)
            {
                figures.Add(currentFigure);
                currentFigure.Paint();
                pictureBox1.Image = bitmapSingleton.bitmap;
            }



            prevPoint = e.Location;

            if (mode == "Pipete")
            {
                pen.Color = bitmapSingleton.bitmap.GetPixel(e.Location.X, e.Location.Y);
                mode = "Paint";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmapSingleton.bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Bitmap bitmap = (Bitmap)bitmapSingleton.bitmap;

            pen = new Pen(colorDialog1.Color, trackBar1.Value);
            mode = "Paint";
            factory = new LineFactory();
        }

        

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
        }


        private void buttonPipette_Click(object sender, EventArgs e)
        {
            mode = "Pipete";
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                pen.Color = colorDialog1.Color;
            }
        }


        private void LineTools_Click(object sender, EventArgs e)
        {
            mode = "Paint";
            factory = new LineFactory();
        }

        private void RectangleTools_Click(object sender, EventArgs e)
        {
            mode = "Paint";
            factory = new RectangleFactory();
        }

        private void EllipseTools_Click(object sender, EventArgs e)
        {
            mode = "Paint";
            factory = new EllipseFactory();
        }

        private void RhombusTools_Click(object sender, EventArgs e)
        {
            mode = "Paint";
            factory = new RhombusFactory();
        }

        private void IsoscelesTriangleTools_Click(object sender, EventArgs e)
        {
            mode = "Paint";
            factory = new IsoscelesTriangleFactory();
        }

        private void RightTriangleTools_Click(object sender, EventArgs e)
        {
            mode = "Paint";
            factory = new RightTriangleFactory();
        }

        private void BrokenLineTools_Click(object sender, EventArgs e)
        {
            mode = "Paint";
            factory = new LineFactory();
        }

        private void EraserTriangle_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)bitmapSingleton.bitmap.Clone();
            figures.Clear();
            Graphics graphics;
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);

            pictureBox1.Image = bitmap;
        }

        private void BrushTools_Click(object sender, EventArgs e)
        {
            mode = "Brush";
            
            factory = new BrushFactory();
        }

        public void DrawAll()
        {
            Bitmap bitmap = (Bitmap)bitmapSingleton.bitmap.Clone();
            Graphics graphics;
            graphics = Graphics.FromImage(bitmap);

            foreach (AFigure figure in figures)
            {
                figure.Paint();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(mode == "Move")
            {
                mode = "Paint";
            }
            else
            {
                mode = "Move";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mode == "Rotate")
            {
                mode = "Paint";
            }
            else
            {
                mode = "Rotate";

            }
        }

        private void buttonMoveVertex_Click(object sender, EventArgs e)
        {
            if (mode == "MoveVertex")
            {
                mode = "Paint";
            }
            else
            {
                mode = "MoveVertex";

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            mode = "Paint";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            mode = "Move";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            mode = "MoveVertex";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            mode = "AddPoint";
        }

        
    }
}
