using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ScreenDraw.Drawables
{
    public class Curve : Drawable
    {
        public Point StartPoint { get; set; }
        public List<Point> Points { get; }

        private Point[] pointCache;

        public Pen Pen { get; set; }

        public Rectangle BoundingBox => DrawHelper.BoundingBox(pointCache);

        public Curve()
        {
            Points = new List<Point>();
            pointCache = new Point[0];
        }

        public void AddPoint(Point point)
        {
            if (Points.Count > 0)
            {
                if (Points[Points.Count -1] == point) return;
            }

            Points.Add(point);
            pointCache = (new Point[] { StartPoint }).Union(Points).ToArray();
        }
        public void Draw(Graphics graphics)
        {
            if (pointCache.Length == 0) return;

            graphics.DrawCurve(Pen, pointCache);
        }
    }
}