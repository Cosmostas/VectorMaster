using NUnit.Framework;
using System.Collections;
using System.Drawing;
using VectorMaster;

namespace VectorMasterTest
{
    public class RectangleCalculatorTest
    {
        [Test, TestCaseSource(typeof(GetPointMock))]
        public void Calculate(Point firstPoint, Point lastPoint, Point[] Expected)
        {
            RectangleFigure rectangle = new RectangleFigure();
            Point[] actual = rectangle.Calculate(firstPoint,lastPoint).ToArray();
            Assert.AreEqual(Expected, actual);
        }
    }

    public class GetPointMock : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new Point(0, 0), new Point(10, 10), new Point[] { new Point(0, 0), new Point(10, 0), new Point(10, 10), new Point(0, 10) } };
            yield return new object[] { new Point(10, 10), new Point(0, 0), new Point[] { new Point(10, 10), new Point(0,10), new Point(0, 0), new Point(10, 0) } };
            yield return new object[] { new Point(0, 10), new Point(10, 0), new Point[] { new Point(0, 10), new Point(10,10), new Point(10, 0), new Point(0, 0) } };
            yield return new object[] { new Point(10, 0), new Point(0, 10), new Point[] { new Point(10, 0), new Point(0,0), new Point(0, 10), new Point(10, 10) } };

            
        }
    }

}