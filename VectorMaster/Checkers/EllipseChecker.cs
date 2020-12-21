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
        public bool CheckHit(Point dot, List<Point> Points, int Width)
        {
            Point Center = new Point(Points[0].X + Points[1].X / 2, Points[0].Y + Points[1].Y / 2);

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
                { return true; }
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
                { return true; }
                else
                {
                    return false;

                }
            }
        }

        public int CheckHitInVertex(Point dot, List<Point> Points)
        {
            throw new NotImplementedException();
        }
    }
}
