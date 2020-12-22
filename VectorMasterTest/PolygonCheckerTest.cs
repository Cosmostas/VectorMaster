using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using VectorMaster;
using VectorMaster.Figures;

namespace VectorMasterTest
{
    public class PolygonCheckerTest
    {

        [Test, TestCaseSource(typeof(GetPointMock))]
        public void CheckHit(Point dot, List<Point> Points, int Width, bool expected)
        {

            IsoscelesTriangleTestFigure rectangle = new IsoscelesTriangleTestFigure(Color.Black, Width);

            rectangle.points = Points;


        }

        public class GetPointMock : IEnumerable
        {
            public IEnumerator Enumerator
            {
                get
                {
                    yield return new object[] { new Point(7, 3), new List<Point>(4) 
                    { new Point(5, 5), new Point(10, 5), new Point(10, 10), new Point(5, 10) }, 4, true };



                }
            }
        }


    }
}
