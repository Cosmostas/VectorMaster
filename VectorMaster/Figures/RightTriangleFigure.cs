using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorMaster.Calculators;

namespace VectorMaster.Figures
{
    public class RightTriangleFigure : AFigure
    {
        public RightTriangleFigure()
        {
            listPoints = new List<Point>();

            painter = new PolygonPainter();
            calculator = new RightTriangleCalculator();

        }
        public RightTriangleFigure(Pen pen)
        {
            listPoints = new List<Point>();
            this.pen = pen;

            painter = new PolygonPainter();
            calculator = new RightTriangleCalculator();
        }
        public RightTriangleFigure(Color color, int width)
        {
            listPoints = new List<Point>();
            this.pen = new Pen(color, width);

            painter = new PolygonPainter();
            calculator = new RightTriangleCalculator();
        }
    }
}
