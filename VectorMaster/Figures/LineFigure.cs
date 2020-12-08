using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster
{
    public class LineFigure : IFigure
    {
        public Point _beginLine { get; private set; }
        public Point _endLine{ get; private set; }
    public LineFigure()
        {

        }
        public LineFigure(Point beginLine, Point endLine)
        {
            _beginLine = beginLine;
            _endLine = endLine;
        }

        public void SetPoint(Point beginLine, Point endLine)
        {
            _beginLine = beginLine;
            _endLine = endLine;
        }
        public List<Point> GetPoints()
        {
            return new List<Point>() { _beginLine, _endLine};
        }

    }
}
