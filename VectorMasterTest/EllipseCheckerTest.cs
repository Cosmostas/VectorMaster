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
    public class EllipseCheckerTest
    {
        [Test, TestCaseSource(typeof(GetPointMock))]
        public void CheckHit(Point dot, List<Point> Points, int Width, List<Point> Expected)
        {
            EllipseFigure ellipse = new EllipseFigure(Color.Black, Width);
            List<Point> Actual = ellipse.CheckHit(dot);
            Assert.AreEqual(Expected, Actual);

        }

        public class GetPointMock : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[] { new Point(15, 15), new List<Point>(2) { new Point(5, 5), new Point(10, 10)}, 4, new List<Point> {new Point(15, 15) } };

            }
        }
    }
}
