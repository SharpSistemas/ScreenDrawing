using System;
using System.Drawing;
using System.Linq;

namespace ScreenDraw.Drawables
{
    public static class DrawHelper
    {
        public static Rectangle RectangleFromPoints(Point start, Point end)
        {
            return new Rectangle(Math.Min(start.X, end.X),
                                 Math.Min(start.Y, end.Y),
                                 Math.Abs(start.X - end.X),
                                 Math.Abs(start.Y - end.Y));
        }
        public static Rectangle BoundingBox(Point[] points)
        {
            if (points.Length < 2) return new Rectangle();

            Point start = new Point(points.Min(p => p.X), points.Min(p => p.Y));
            Point end = new Point(points.Max(p => p.X), points.Max(p => p.Y));

            return RectangleFromPoints(start, end);
        }
        public static Point Snap(Point p1, Point newPoint, bool SnapVH, bool snap45)
        {
            int snapDiff = 15;
            var dist = Distance(p1, newPoint);
            if (dist < snapDiff) return newPoint;

            var diffX = Math.Abs(p1.X - newPoint.X);
            var diffY = Math.Abs(p1.Y - newPoint.Y);
            // V/H
            if (SnapVH)
            {
                if (diffX < snapDiff) return new Point(p1.X, newPoint.Y);
                if (diffY < snapDiff) return new Point(newPoint.X, p1.Y);
            }

            // 45
            if (snap45 && Math.Abs(diffX - diffY) < snapDiff)
            {
                double coordDiff = Math.Sqrt(dist * dist / 2);

                var signX = Math.Sign(newPoint.X - p1.X);
                var signY = Math.Sign(newPoint.Y - p1.Y);

                return new Point((int)(p1.X + signX * coordDiff), (int)(p1.Y + signY * coordDiff));
            }

            return newPoint;
        }
        public static double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(
                (p1.X - p2.X) * (p1.X - p2.X) +
                (p1.Y - p2.Y) * (p1.Y - p2.Y));
        }
    }
}
