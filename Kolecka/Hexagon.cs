using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolecka
{
    public class Hexagon : Polygon
    {
        public Hexagon(Point origin, Color color, bool filled) : base(origin, color, filled)
        {
        }

        public override void Draw(Graphics g, bool drawCenters)
        {
            this.points.Add(new Point((int)(origin.X + size.Width / 2), origin.Y));
            this.points.Add(new Point((int)(origin.X + size.Width), (int)(origin.Y + size.Height / 4)));
            this.points.Add(new Point((int)(origin.X + size.Width), (int)(origin.Y + size.Height * 3 / 4)));
            this.points.Add(new Point((int)(origin.X + size.Width / 2), (int)(origin.Y + size.Height)));
            this.points.Add(new Point(origin.X, (int)(origin.Y + size.Height * 3 / 4)));
            this.points.Add(new Point(origin.X, (int)(origin.Y + size.Height / 4)));

            base.Draw(g, drawCenters);
        }
    }
}
