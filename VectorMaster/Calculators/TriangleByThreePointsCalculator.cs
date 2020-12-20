using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.Calculators
{
    public class TriangleByThreePointsCalculator : ICalculator
    {
        public List<Point> Calculate(Point firstPoint, Point lastPoint)
        {
            return new List<Point>(3) { firstPoint, new Point(firstPoint.X, lastPoint.Y), lastPoint };
        }
    }
}


/*namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private struct Triangle
        {
            public Point p1;
            public Point p2;
            public Point p3;
        }
        List<Triangle> mTriangles = new List<Triangle>();
        Triangle mCurrent;
        int mPoints;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Draw existing triangles
            foreach (Triangle t in mTriangles)
            {
                e.Graphics.DrawLine(Pens.Black, t.p1, t.p2);
                e.Graphics.DrawLine(Pens.Black, t.p2, t.p3);
                e.Graphics.DrawLine(Pens.Black, t.p3, t.p1);
            }
            // Draw rubber-band
            Point pos = this.PointToClient(Cursor.Position);
            if (mPoints == 1) e.Graphics.DrawLine(Pens.Black, mCurrent.p1, pos);
            if (mPoints == 2) e.Graphics.DrawLine(Pens.Black, mCurrent.p2, pos);
            // Draw edge
            if (mPoints >= 2) e.Graphics.DrawLine(Pens.Black, mCurrent.p1, mCurrent.p2);
        }

        void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // Show rubber-band
            if (mPoints > 0) this.Invalidate();
        }

        void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Erase with the right-mouse button
                mPoints = 0;
                Invalidate();
                return;
            }
            // Add point to triangle
            if (mPoints == 0) mCurrent.p1 = e.Location;
            else if (mPoints == 1) mCurrent.p2 = e.Location;
            else
            {
                mCurrent.p3 = e.Location;
                // Got a full triangle
                mTriangles.Add(mCurrent);
                mCurrent = new Triangle();
                mPoints = -1;  // hack
            }
            mPoints++;
            Invalidate();
        }
    }
}
*/
