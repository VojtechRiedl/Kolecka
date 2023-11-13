using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolecka
{
    public abstract class Polygon : Shape
    {

        protected List<Point> points = new List<Point>();

        public Polygon(Point origin, Color color, bool filled) : base(origin, color, filled)
        {
            this.size = new CustomSize(0, 0);
        }

        public override CustomSize CalcSize(Point location, bool keepRatio)
        {
            int xdiff = location.X - origin.X;
            int ydiff = location.Y - origin.Y;
            if (keepRatio)
            {
                return xdiff > ydiff ? new CustomSize(xdiff) : new CustomSize(ydiff);
            }

            return new CustomSize(xdiff, ydiff);
        }

        public override void ChangeSize(CustomSize size)
        {
            this.size = size;
        }

        public override bool ContainsPoint(Point location, out float distance)
        {
            distance = location.Distance(origin);
            int count = 0;

            for (int i = 0, j = points.Count - 1; i < points.Count; j = i++)
            {
                if ((points[i].Y > location.Y) != (points[j].Y > location.Y) &&
                location.X < (points[j].X - points[i].X) * (location.Y - points[i].Y) / (points[j].Y - points[i].Y) + points[i].X)
                {
                    count++;
                }
            }
            return count % 2 == 1;

        }

        public override void Draw(Graphics g, bool drawCenters)
        {
            if (filled)
            {
                g.FillPolygon(colorBrush, points.ToArray());
            }
            else
            {
                g.DrawPolygon(colorPen, points.ToArray());
            }

            if (selected)
            {
                g.DrawPolygon(outlinePen, points.ToArray());
            }
            if (drawCenters)
            {
                Point center = new Point((int)(origin.X + size.Width / 2), (int)(origin.Y + size.Height / 2));
                g.DrawLine(centerPen, center.X - centerSize, center.Y, center.X + centerSize, center.Y);
                g.DrawLine(centerPen, center.X, center.Y - centerSize, center.X, center.Y + centerSize);
            }

        }

    }
}
