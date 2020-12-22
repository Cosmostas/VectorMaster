using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.Checkers
{
    public class EllipseChecker : IChecker
    {
        public List<Point> CheckHit(Point dot, List<Point> Points, int Width)
        {
            int pX = Points[0].X;
            int pY = Points[0].Y;
            int sizeX = Points[1].X;
            int sizeY = Points[1].Y;

            Point Center = new Point(Points[0].X + Points[1].X / 2, Points[0].Y + Points[1].Y / 2);
            List<Point> dots = new List<Point>(4) { new Point(pX, pY + sizeY / 2), new Point(pX + sizeX / 2, pY), new Point(pX + sizeX, pY + sizeY / 2), new Point(pX + sizeX / 2, pY + sizeY) };

            for (int i = 0; i < dots.Count; i++)
            {
                if (Math.Abs(dots[i].X - dot.X) < Width / 2 && Math.Abs(dots[i].Y - dot.Y) < Width / 2)
                {
                    return new List<Point>(1) { dots[i] };
                }
            }

            Point startAccuracyLine = new Point(dot.X - Width / 2, dot.Y - Width / 2);
            Point endAccuracyLine = new Point(dot.X + Width / 2, dot.Y + Width / 2);

            float a = Points[1].X / 2;
            float b = Points[1].Y / 2;

            if( 
                (Math.Pow(startAccuracyLine.X - Center.X, 2) / (a*a) + Math.Pow(startAccuracyLine.Y - Center.Y, 2) / (b*b) <= 1
                &&
                Math.Pow(endAccuracyLine.X - Center.X, 2) / (a * a) + Math.Pow(endAccuracyLine.Y - Center.Y, 2) / (b * b) >= 1)
                ||
                (Math.Pow(startAccuracyLine.X - Center.X, 2) / (a * a) + Math.Pow(startAccuracyLine.Y - Center.Y, 2) / (b * b) >= 1
                &&
                Math.Pow(endAccuracyLine.X - Center.X, 2) / (a * a) + Math.Pow(endAccuracyLine.Y - Center.Y, 2) / (b * b) <= 1)
                )
                { return new List<Point>(1) { dot}; }
            else
            {
                startAccuracyLine = new Point(dot.X - Width / 2, dot.Y + Width / 2);
                endAccuracyLine = new Point(dot.X + Width / 2, dot.Y - Width / 2);
                if (
                     (Math.Pow(startAccuracyLine.X - Center.X, 2) / (a * a) + Math.Pow(startAccuracyLine.Y - Center.Y, 2) / (b * b) <= 1
                     &&
                     Math.Pow(endAccuracyLine.X - Center.X, 2) / (a * a) + Math.Pow(endAccuracyLine.Y - Center.Y, 2) / (b * b) >= 1)
                     ||
                     (Math.Pow(startAccuracyLine.X - Center.X, 2) / (a * a) + Math.Pow(startAccuracyLine.Y - Center.Y, 2) / (b * b) >= 1
                     &&
                     Math.Pow(endAccuracyLine.X - Center.X, 2) / (a * a) + Math.Pow(endAccuracyLine.Y - Center.Y, 2) / (b * b) <= 1)
                     )
                { return new List<Point>(1) { dot }; }
                else
                {
                    return null;

                }
            }
        }


    }
}
