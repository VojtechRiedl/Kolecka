using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolecka
{
    public class Arrow : Polygon
    {
        public Arrow(Point origin, Color color, bool filled) : base(origin, color, filled)
        {
        }


        public override void Draw(Graphics g, bool drawCenters)
        {
            this.points.Add(new Point((int)(origin.X - size.Width * 0.4), (int)(origin.Y + size.Height * 0.1)));
            this.points.Add(new Point(origin.X, (int)(origin.Y - size.Height * 0.5)));
            this.points.Add(new Point((int)(origin.X + size.Width * 0.4), (int)(origin.Y + size.Height * 0.1)));
            this.points.Add(new Point((int)(origin.X - size.Width * 0.2), origin.Y));
            this.points.Add(new Point((int)(origin.X + size.Width * 0.2), origin.Y));
            this.points.Add(new Point((int)(origin.X - size.Width * 0.4), (int)(origin.Y + size.Height * 0.1)));




            base.Draw(g, drawCenters);
        }
    }
}
