using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolecka
{
    public class Square : Shape
    {

        private float size;
        public Square(Point center, Color color, bool filled) : base(center, color, filled)
        {
            this.size = 0;
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
            return location.X > origin.X ||
                location.X < origin.X + size ||
                location.Y > origin.Y ||
                location.Y < origin.Y + size;
        }

        public override void Draw(Graphics g, bool drawCenters)
        {
            if (filled)
            {
                g.FillRectangle(colorBrush, origin.X - size, origin.Y - size,size,size);
            }
            else
            {
                g.DrawRectangle(colorPen, origin.X - size, origin.Y - size,size,size);
            }

            if (selected)
            {
                g.DrawRectangle(outlinePen, origin.X - size, origin.Y - size,size,size);
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
