using System.Drawing;

namespace ScreenDraw.Drawables
{
    public class Box : Drawable
    {
        public Point StartPoint { get; set; }
        public Point P2 { get; set; }
        public Pen Pen { get; set; }

        public Rectangle BoundingBox => DrawHelper.RectangleFromPoints(StartPoint, P2);

        public void AddPoint(Point point)
        {
            P2 = point;
        }
        public void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(Pen, BoundingBox);
        }
    }
}