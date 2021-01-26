using System.Drawing;

namespace ScreenDraw.Drawables
{
    public class Line : Drawable
    {
        public Point StartPoint { get; set; }
        public Point P2 { get; set; }
        public Pen Pen { get; set; }

        public Rectangle BoundingBox => DrawHelper.RectangleFromPoints(StartPoint, P2);

        public void AddPoint(Point point)
        {
            P2 = DrawHelper.Snap(StartPoint, point, SnapVH: true, snap45: true);
        }
        public void Draw(Graphics graphics)
        {
            graphics.DrawLine(Pen, StartPoint, P2);
        }
    }
}