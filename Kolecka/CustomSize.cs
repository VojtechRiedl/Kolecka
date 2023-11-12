using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolecka
{
    public class CustomSize
    {
        float width;
        float height;

        public float Width { get => width; set => width = value; }
        public float Height { get => height; set => height = value; }

        public CustomSize(float width, float height)
        {
            this.Width = width;
            this.Height = height;
        }

        public CustomSize(float size)
        {
            this.Width = size;
            this.Height = size;
        }

        public bool IsSame()
        {
            return width == height;
        }
       
    }
}
