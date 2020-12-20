using NUnit.Framework;
using System;
using System.Collections;
using System.Drawing;
using VectorMaster;

namespace VectorPaintNUnitTest
{
    public class RightTriangleTest
    {
        [Test, TestCaseSource(typeof(GetPointMock))]
        public void Calculate (Point firstPoint, Point lastPoint, Point[] Expected)
        {
            RightTriangleTest triangle = new RightTriangleTest();
            Point[] actual = (Point[])triangle.Calculate(firstPoint, lastPoint);
            Assert.AreEqual(Expected, actual);
        }

        private object Calculate(Point firstPoint, Point lastPoint)
        {
            throw new NotImplementedException();
        }
    }

    public class GetPointMock : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new Point(0, 0), new Point(10, 10), new Point[]
            { new Point(0, 0), new Point(10, 10), new Point(-10, 10) } };

            yield return new object[] { new Point(10, 10), new Point(0, 0), new Point[]
            { new Point(10, 10), new Point(-10, 10), new Point(0, 0) } };

            yield return new object[] { new Point(0, 10), new Point(10, 0), new Point[]
            { new Point(0, 10), new Point(20, 10), new Point(10, 0) } };

            yield return new object[] { new Point(10, 0), new Point(0, 10), new Point[]
            { new Point(10, 0), new Point(10, 0), new Point(20, 10) } };

        }
    }
}
