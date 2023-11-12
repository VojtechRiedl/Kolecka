using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolecka
{
    public class Circle : Shape
    {

        private float radius;
        public float Radius { get => radius; set => radius = value; }

        public Circle(Point center, Color color, bool filled) : base(center, color, filled)
        {
            this.radius = 0;
        }


        public override void Draw(Graphics g, bool drawCenters)
        {
            
            if (filled)
            {
                g.FillEllipse(colorBrush, origin.X - radius, origin.Y - radius, 2 * radius, 2 * radius);
            }
            else
            {
                g.DrawEllipse(colorPen, origin.X - radius, origin.Y - radius, 2 * radius, 2 * radius);
            }

            if (selected)
            {
                g.DrawEllipse(outlinePen, origin.X - radius, origin.Y - radius, 2 * radius, 2 * radius);
            }
            if (drawCenters)
            {
                g.DrawLine(centerPen, origin.X - centerSize, origin.Y, origin.X + centerSize, origin.Y);
                g.DrawLine(centerPen, origin.X, origin.Y - centerSize, origin.X, origin.Y + centerSize);
            }
        }

        public override void ChangeSize(CustomSize size)
        {
            this.radius = size.Width;
        }

        public override bool ContainsPoint(Point location, out float distance)
        {
            distance =location.Distance(origin);
            return distance < radius;
        }


        public override CustomSize CalcSize(Point location, bool keepRatio = true)
        {
            return new CustomSize(location.Distance(origin));
        }
    }
}
