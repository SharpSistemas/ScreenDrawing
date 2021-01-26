using System.Drawing;

namespace ScreenDraw
{
    public interface Drawable
    {
        Point StartPoint { get; }
        Rectangle BoundingBox { get; }

        void Draw(Graphics graphics);
        void AddPoint(Point point);

    }
    public enum DrawableTool
    {
        Line, 
        Arrow,
        Curve,
        Elipse,
        Rectangle,
    }
}
