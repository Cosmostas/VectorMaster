using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorMaster.Calculators;
using VectorMaster.Painters;

namespace VectorMaster.Figures
{
    public class BrushFigure : AFigure
    {
        public BrushFigure()
        {
            listPoints = new List<Point>();

            painter = new LinePainter();

        }
        public BrushFigure(Pen pen)
        {
            listPoints = new List<Point>();
            this.pen = pen;

            painter = new LinePainter();
        }
        public BrushFigure(Color color, int width)
        {
            listPoints = new List<Point>();
            this.pen = new Pen(color, width);

            painter = new LinePainter();
        }
    }
}
