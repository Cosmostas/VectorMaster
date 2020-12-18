using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using VectorMaster.Figures;

namespace VectorMasterTest
{
    public class PolygonCheckerTest
    {

        [Test, TestCaseSource(typeof(GetPointMock))]
        public void CheckHit(Point dot, List<Point> Points, int Width, bool expected)
        {

            RightTriangleFigure rightTriangle = new RightTriangleFigure(Color.Black, Width);
            rightTriangle.listPoints = Points;
            bool actual = rightTriangle.CheckHit(dot);
            Assert.AreEqual(expected, actual);
        }

        public class GetPointMock : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[] { new Point (10,10), new List<Point>(3) {new Point(1,1), new Point(5, 5), new Point(1, 5)}, 4, false};
                yield return new object[] { new Point (2,2), new List<Point>(3) {new Point(1,1), new Point(5, 5), new Point(1, 5)}, 4, true};
                yield return new object[] { new Point (2,5), new List<Point>(3) {new Point(1,1), new Point(5, 5), new Point(1, 5)}, 4, true};
                yield return new object[] { new Point (2,4), new List<Point>(3) {new Point(1,1), new Point(5, 5), new Point(1, 5)}, 4, true};
                yield return new object[] { new Point (2,3), new List<Point>(3) {new Point(1,1), new Point(5, 5), new Point(1, 5)}, 4, false};


            }
        }
    }
}
