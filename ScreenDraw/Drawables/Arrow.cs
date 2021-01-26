using System.Drawing;
using System.Drawing.Drawing2D;

namespace ScreenDraw.Drawables
{
    public class Arrow : Drawable
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
            using (GraphicsPath capPath = new GraphicsPath())
            {
                int arrowHead = 5;

                capPath.AddLine(-arrowHead, -arrowHead, 0, 0);
                capPath.AddLine(arrowHead, -arrowHead, 0, 0);
                Pen.CustomEndCap = new CustomLineCap(null, capPath);

                graphics.DrawLine(Pen, StartPoint, P2);
            }
        }
    }
}
