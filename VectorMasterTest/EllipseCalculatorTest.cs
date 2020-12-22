using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using VectorMaster;
using VectorMaster.Figures;

namespace VectorMasterTest
{
    public class EllipseCalculatorTest
    {
        [Test, TestCaseSource(typeof(GetPointsTestMock))]
        public void GetPointsTest(Point p1, Point p2, List<Point> expected)
        {
            Canvas canvas = Canvas.CreateCanvas();
            canvas.prevPoint = p1;
            canvas.curPoint = p2;
            
            EllipseFigure ellipseFigure = new EllipseFigure();
            List<Point> actual = ellipseFigure.Calculate();

            Assert.AreEqual(expected, actual);
        }

        public class GetPointsTestMock : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[] { new Point(0, 0), new Point(10, 10), new List<Point> { new Point(0, 0), new Point(10, 10) } };
                yield return new object[] { new Point(5, 5), new Point(25, 35), new List<Point> { new Point(5, 5), new Point(20, 30) } };
                yield return new object[] { new Point(20, 30), new Point(40, 40), new List<Point> { new Point(20, 30), new Point(20, 10) } };
            }
        }
    }
}
