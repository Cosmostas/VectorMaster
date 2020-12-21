using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VectorMaster.Factory;
using VectorMaster.MouseHandler;

namespace VectorMaster
{
    public class Canvas
    {
        static private Canvas _instance;

        public Bitmap bitmap;
        public PictureBox pictureBox;

        public Pen pen;

        public List<AFigure> figures = new List<AFigure>();

        public AFigure currentFigure;

        public IFactory factory;

        public IMouseHandler MouseHandler = new PaintMouseHandler();

        public bool isMouseDown = false;

        public Point prevPoint = new Point(0, 0);
        public Point curPoint = new Point(0, 0);

        public String mode;

        public int index;

        private Canvas() {  }

        public static Canvas CreateCanvas()
        {
            if(_instance == null)
            {
                _instance = new Canvas();
                return _instance;
            }
            else
            {
                return _instance;
            }
        }
        public void DrawAll()
        {

            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);

            Graphics graphics;
            graphics = Graphics.FromImage(bitmap);

            foreach (AFigure figure in figures)
            {
                figure.Paint();
            }
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
    }
}
