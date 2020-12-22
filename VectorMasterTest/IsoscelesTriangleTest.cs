using NUnit.Framework;
using System.Collections;
using System.Drawing;
using VectorMaster;
using VectorMaster.Figures;

namespace VectorMasterTest
{
    public class IsoscelesTriangleTest
    {

        [Test, TestCaseSource(typeof(GetPointMock))]
        public void Calculate(Point firstPoint, Point lastPoint, Point[] Expected)
        {
            IsoscelesTriangleFigure rectangle = new IsoscelesTriangleFigure();
            Point[] actual = rectangle.Calculate(firstPoint, lastPoint).ToArray();
            Assert.AreEqual(Expected, actual);
        }
    }

    public class GetPointMock : IEnumerable
    {
        public IEnumerator Enumerator
        {
            get
            {
                yield return new object[] { new Point(0, 0), new Point(10, 10), new Point[]
            { new Point(0, 0), new Point(10, 10), new Point(-10, 10) } };
                yield return new object[] { new Point(10, 10), new Point(0, 0), new Point[]
            { new Point(10, 10), new Point(0 , 0), new Point(20, 0), } };
                yield return new object[] { new Point(0, 10), new Point(10, 0), new Point[]
            { new Point(0, 10), new Point(10,0), new Point(-10, 0),  } };
                yield return new object[] { new Point(10, 0), new Point(0, 10), new Point[]
            { new Point(10, 0), new Point(0,10),  new Point(20, 10) } };


            }
        }

        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}