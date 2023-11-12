using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolecka
{
    public class Triangle : Polygon
    {
        public Triangle(Point origin, Color color, bool filled) : base(origin, color, filled)
        {
        }

        public override void Draw(Graphics g, bool drawCenters)
        {
            this.points.Add(new Point((int)(origin.X + size.Width / 2), origin.Y));
            this.points.Add(new Point((int)(origin.X + size.Width), (int)(origin.Y + size.Height)));
            this.points.Add(new Point(origin.X, (int)(origin.Y + size.Height)));


            base.Draw(g, drawCenters);
        }

    }
}
