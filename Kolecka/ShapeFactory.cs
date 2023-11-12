using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolecka
{
    public class ShapeFactory
    {

        public Color color { get; set; }

        public bool filled { get; set; }
        
        public Shape CreateShape(Type type, Point loc)
        {
            return Activator.CreateInstance(type, new object[] {loc, color, filled}) as Shape;
        }

    }
}
