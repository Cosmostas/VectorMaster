using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster
{
    public class RectangleFigure : IFigure
    {
        List<LineFigure> listLineFigures;
        public RectangleFigure()
        {
            listLineFigures = new List<LineFigure>(4) {
                new LineFigure(),
                new LineFigure(),
                new LineFigure(),
                new LineFigure()
            };
        }
        public RectangleFigure(Point firstPoint, Point lastPoint)
        {
            listLineFigures = new List<LineFigure>(4) {
                new LineFigure(firstPoint, new Point(firstPoint.X, lastPoint.Y)),
                new LineFigure(new Point(firstPoint.X, lastPoint.Y), lastPoint),
                new LineFigure(lastPoint, new Point(lastPoint.X, firstPoint.Y)),
                new LineFigure(new Point(lastPoint.X, firstPoint.Y), firstPoint)
            };
        }

        public List<Point> GetPoints()
        {
            List<Point> dots = new List<Point>(4) {
                listLineFigures[0]._beginLine,
                listLineFigures[1]._beginLine,
                listLineFigures[2]._beginLine,
                listLineFigures[3]._beginLine
            };

            return dots;
        }

        public void SetPoint(Point firstPoint, Point lastPoint)
        {
            listLineFigures = new List<LineFigure>(4) {
                new LineFigure(firstPoint, new Point(firstPoint.X, lastPoint.Y)),
                new LineFigure(new Point(lastPoint.X, firstPoint.Y), lastPoint),
                new LineFigure(lastPoint, new Point(lastPoint.X, firstPoint.Y)),
                new LineFigure(new Point(firstPoint.X, lastPoint.Y), firstPoint)
            };
        }
    
    }
}
