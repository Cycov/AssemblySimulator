using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    public static class GraphicsExtensions
    {
        public static void DrawArrow(this Graphics g, Pen pen, Point p1, Point p2)
        {
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Flat;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(pen, p1, p2);
        }

        public static void DrawALU(this Graphics g, Pen pen, Rectangle bounds)
        {
            int tenPercentOfWidth = bounds.Width / 10;
            int twentyPercentOfHeight = bounds.Height / 5;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            Point[] points = new Point[] {
                bounds.Location,
                new Point(bounds.X + bounds.Width/2 - tenPercentOfWidth, bounds.Y),
                new Point(bounds.X + bounds.Width/2, bounds.Y + twentyPercentOfHeight),
                new Point(bounds.X + bounds.Width / 2 + tenPercentOfWidth, bounds.Y),
                new Point(bounds.X + bounds.Width, bounds.Y),
                new Point(bounds.X + bounds.Width - tenPercentOfWidth * 3, bounds.Y + bounds.Height),
                new Point(bounds.X + tenPercentOfWidth * 3, bounds.Y + bounds.Height),
                bounds.Location
            };
            path.AddLines(points);
            path.CloseFigure();
            g.DrawPath(pen, path);
        }
    }
}
