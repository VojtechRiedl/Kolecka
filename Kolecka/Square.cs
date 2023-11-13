using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolecka
{
    public class Square : Shape
    {
        public Square(Point center, Color color, bool filled) : base(center, color, filled)
        {
            size = new CustomSize(0, 0);
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
            return location.X > origin.X &&
                location.X < origin.X + size.Width &&
                location.Y > origin.Y &&
                location.Y < origin.Y + size.Height;
        }

        public override void Draw(Graphics g, bool drawCenters)
        {
            if (filled)
            {
                g.FillRectangle(colorBrush, origin.X, origin.Y,(int)size.Width, (int)size.Height);
            }
            else
            {
                g.DrawRectangle(colorPen, origin.X, origin.Y, (int)size.Width, (int)size.Height);
            }

            if (selected)
            {
                g.DrawRectangle(outlinePen, origin.X, origin.Y, (int)size.Width, (int)size.Height);
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
