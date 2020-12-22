using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using VectorMaster.Figures;

namespace VectorMasterTest
{
    public class RhombusCalculatorTest
    {
        [Test, TestCaseSource(typeof(GetPointsTestMock))]
        public void GetPointsTest(Point p1, Point p2, List<Point> expected)
        {
            RhombusFigure rhombusFigure = new RhombusFigure();
            List<Point> actual = rhombusFigure.Calculate();
            Assert.AreEqual(expected, actual);
        }

        public class GetPointsTestMock : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {

                yield return new object[] { new Point(0, 0), new Point(10, 10), new List<Point> { new Point(0, 0), new Point(-10, 5), new Point(0, 10), new Point(10, 5) } };
                yield return new object[] { new Point(20, 30), new Point(5, 10), new List<Point> { new Point(20, 30), new Point(5, 20), new Point(20, 10), new Point(35, 20) } };
                yield return new object[] { new Point(100, 20), new Point(70, 50), new List<Point> { new Point(100, 20), new Point(70, 35), new Point(100, 50), new Point(130, 35) } };

            }
        }
    }
}
