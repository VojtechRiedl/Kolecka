using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolecka
{
    public class Hexagon : Shape
    {
        float size;
        Point[] points;
        public Hexagon(Point origin, Color color, bool filled) : base(origin, color, filled)
        {
            this.size = 0;
            this.points = new Point[6];
        }

        public override float CalcSize(Point location)
        {
            int xdiff = location.X - origin.X;
            int ydiff = location.Y - origin.Y;
            return xdiff > ydiff ? xdiff : ydiff;
        }

        public override void ChangeSize(float size)
        {
            this.size = size;
        }

        public override bool ContainsPoint(Point location, out float distance)
        {
            distance = location.Distance(origin);
            int count = 0;

            for (int i = 0, j = points.Length - 1; i < points.Length; j = i++)
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
            this.points[0] = new Point((int)(origin.X + size / 2), origin.Y);
            this.points[1] = new Point((int)(origin.X + size), (int)(origin.Y + size / 4));
            this.points[2] = new Point((int)(origin.X + size), (int)(origin.Y + size * 3 / 4));
            this.points[3] = new Point((int)(origin.X + size / 2), (int)(origin.Y + size));
            this.points[4] = new Point(origin.X, (int)(origin.Y + size * 3 / 4));
            this.points[5] = new Point(origin.X, (int)(origin.Y + size / 4));
           

            /** next řešení
            this.points = new Point[] {
                    new Point((int)(origin.X + size / 2), origin.Y ),
                    new Point((int)(origin.X + size), (int)(origin.Y + size / 4)),
                    new Point((int)(origin.X + size), (int)(origin.Y + size * 3 / 4)),
                    new Point((int)(origin.X + size / 2),(int)(origin.Y + size)),
                    new Point(origin.X, (int)(origin.Y + size * 3 / 4)),
                    new Point(origin.X, (int)(origin.Y + size / 4)),
                };
            */
            if (filled)
            {
                g.FillPolygon(colorBrush, points);
            }
            else
            {
                g.DrawPolygon(colorPen, points);
            }

            if (selected)
            {
                g.DrawPolygon(outlinePen,points);
            }
            if (drawCenters)
            {
                Point center = new Point((int)(origin.X + size / 2), (int)(origin.Y + size / 2));
                g.DrawLine(centerPen, center.X - centerSize, center.Y, center.X + centerSize, center.Y);
                g.DrawLine(centerPen, center.X, center.Y - centerSize, center.X, center.Y + centerSize);
            }
        }
    }
}
