using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorMaster
{
    public partial class Form1 : Form
    {
        Bitmap Bm;
        Graphics graphics;
        Pen pen;
        List<IPainter> painters = new List<IPainter>();
        IPainter currentPainter;
        bool md = false;
        Point prevPoint = new Point(0,0);

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            prevPoint = e.Location;
            md = true;
            painters.Add(currentPainter);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (md)
            {
                Bitmap tmpBm = (Bitmap)painters[painters.Count - 1].Paint(Bm, pen, prevPoint, e.Location).Clone();

                pictureBox1.Image = tmpBm;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            md = false;


            Bm = (Bitmap) painters[painters.Count - 1].Paint(Bm, pen, prevPoint, e.Location).Clone();

            pictureBox1.Image = Bm;
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pen = new Pen(Color.Black, 1);
        }

        private void Tools1_CheckedChanged(object sender, EventArgs e)
        {
            currentPainter = new LinePainter();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            currentPainter = new RectanglePainter();
        }
    }
}
