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
        Canvas canvas = Canvas.CreateCanvas();

        public Form1()
        {
            InitializeComponent();
        }

   
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            canvas.isMouseDown = true;

            canvas.MouseHandler.RealizeMouseDown();

            pictureBox1.Image = canvas.bitmap;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            canvas.curPoint = e.Location;
            canvas.MouseHandler.RealizeMouseMove();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            canvas.isMouseDown = false;
            canvas.MouseHandler.RealizeMouseup();

            pictureBox1.Image = canvas.bitmap;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canvas.pictureBox = pictureBox1;

            canvas.bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            Bitmap bitmap = (Bitmap)canvas.bitmap;

            canvas.pen = new Pen(colorDialog1.Color, trackBar1.Value);

            canvas.MouseHandler = new BrokenLineMouseHandler();
            canvas.factory = new BrokenLineFactory();
        }

        

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            canvas.pen.Width = trackBar1.Value;
        }


        private void buttonPipette_Click(object sender, EventArgs e)
        {
            canvas.MouseHandler = new PipeteMouseHandler();
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
            canvas.MouseHandler = new PaintMouseHandler();
            canvas.factory = new LineFactory();
        }

        private void RectangleTools_Click(object sender, EventArgs e)
        {
            canvas.MouseHandler = new PaintMouseHandler();
            canvas.factory = new RectangleFactory();
        }

        private void EllipseTools_Click(object sender, EventArgs e)
        {
            canvas.MouseHandler = new PaintMouseHandler();
            canvas.factory = new EllipseFactory();
        }

        private void RhombusTools_Click(object sender, EventArgs e)
        {
            canvas.MouseHandler = new PaintMouseHandler();
            canvas.factory = new RhombusFactory();
        }

        private void IsoscelesTriangleTools_Click(object sender, EventArgs e)
        {
            canvas.MouseHandler = new PaintMouseHandler();
            canvas.factory = new IsoscelesTriangleFactory();
        }

        private void RightTriangleTools_Click(object sender, EventArgs e)
        {
            canvas.MouseHandler = new PaintMouseHandler();
            canvas.factory = new RightTriangleFactory();
        }

        private void BrokenLineTools_Click(object sender, EventArgs e)
        {
            canvas.MouseHandler = new BrokenLineMouseHandler();
            canvas.factory = new BrokenLineFactory();
        }

        private void EraserTriangle_Click(object sender, EventArgs e)
        {
            canvas.bitmap = new Bitmap(canvas.pictureBox.Width, canvas.pictureBox.Height);
            canvas.figures.Clear();
            Graphics graphics;
            graphics = Graphics.FromImage(canvas.bitmap);
            graphics.Clear(Color.White);

            pictureBox1.Image = canvas.bitmap;
        }

        private void BrushTools_Click(object sender, EventArgs e)
        {
            canvas.MouseHandler = new PaintMouseHandler();

            canvas.factory = new BrokenLineFactory();
        }


        private void buttonMoveVertex_Click(object sender, EventArgs e)
        {
            canvas.MouseHandler = new MovePartsFigureMouseHandler();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            canvas.MouseHandler = new MoveMouseHandler();
        }
    }
}
