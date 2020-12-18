using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorMaster.Calculators;
namespace VectorMaster
{
    public class LineFigure : AFigure
    {
        public LineFigure()
        {
            listPoints = new List<Point>();

            painter = new PolygonPainter();
            calculator = new LineCalculator();

        } 
        public LineFigure(Pen pen)
        {
            listPoints = new List<Point>();
            this.pen = pen;

            painter = new PolygonPainter();
            calculator = new LineCalculator();
        }
        public LineFigure(Color color, int width)
        {
            listPoints = new List<Point>();
            this.pen = new Pen(color, width);

            painter = new PolygonPainter();
            calculator = new LineCalculator();
        }

    }
}
