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
        
        bool id_MouseDown = false;

        Point prevPoint = new Point(0,0);

        String Mode;

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
            id_MouseDown = true;

            currentFigure = factory.CreateFigure(pen);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (id_MouseDown)
            {
                Bitmap tmpBm = (Bitmap)Bm.Clone();

                currentFigure.listPoints = currentFigure.Calculate(prevPoint, CalculatePoint(e.Location));

                currentFigure.Paint(tmpBm);
                pictureBox1.Image = tmpBm;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            id_MouseDown = false;

            currentFigure.listPoints = currentFigure.Calculate(prevPoint, CalculatePoint(e.Location));
            figures.Add(currentFigure);

            currentFigure.Paint(Bm);
            pictureBox1.Image = Bm;

            prevPoint = e.Location;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pen = new Pen(Color.Black, 1);
            Mode = "Paint";
        }

        private void Tools1_CheckedChanged(object sender, EventArgs e)
        {
            factory = new LineFactory();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            factory = new RectangleFactory();
        }
    }
}
