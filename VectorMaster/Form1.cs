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
        Bitmap Bm;
        Graphics graphics;
        Pen pen;

        List<AFigure> figures = new List<AFigure>();

        AFigure currentFigure;
        
        IFactory factory;
        
        bool isMouseDown = false;

        Point prevPoint = new Point(0,0);

        String mode;

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
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown && currentFigure != null)
            {
                Bitmap tmpBm = (Bitmap)Bm.Clone();
                switch (mode)
                {
                    case "Paint":
                        currentFigure.listPoints = currentFigure.Calculate(prevPoint, CalculatePoint(e.Location));
                        break;
                    case "Move":
                        Point delta = new Point(e.Location.X - prevPoint.X, e.Location.Y - prevPoint.Y);
                        currentFigure.Move(delta, currentFigure.listPoints);
                        prevPoint = e.Location;
                        break;
                }
                currentFigure.Paint(tmpBm);
                pictureBox1.Image = tmpBm;
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
                currentFigure.Paint(Bm);
                pictureBox1.Image = Bm;
            }



            prevPoint = e.Location;

            if (mode == "Pipete")
            {
                pen.Color = Bm.GetPixel(e.Location.X, e.Location.Y);
                mode = "Paint";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
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
            factory = new LineFactory();
        }

        private void RectangleTools_Click(object sender, EventArgs e)
        {
            factory = new RectangleFactory();
        }

        private void EllipseTools_Click(object sender, EventArgs e)
        {
            factory = new EllipseFactory();
        }

        private void RhombusTools_Click(object sender, EventArgs e)
        {
            factory = new RhombusFactory();
        }

        private void IsoscelesTriangleTools_Click(object sender, EventArgs e)
        {
            factory = new IsoscelesTriangleFactory();
        }

        private void RightTriangleTools_Click(object sender, EventArgs e)
        {
            factory = new RightTriangleFactory();
        }

        private void BrokenLineTools_Click(object sender, EventArgs e)
        {
            factory = new LineFactory();
        }

        private void EraserTriangle_Click(object sender, EventArgs e)
        {
            figures.Clear();

            graphics = Graphics.FromImage(Bm);
            graphics.Clear(Color.White);

            pictureBox1.Image = Bm;
        }

        public void DrawAll()
        {
            Bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(Bm);

            foreach (AFigure figure in figures)
            {
                figure.Paint(Bm);
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
    }
}
