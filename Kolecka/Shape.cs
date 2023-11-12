using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolecka
{
    public abstract class Shape
    {

        protected static Pen outlinePen = new Pen(Color.Yellow, 4f);

        protected static Pen centerPen = new Pen(Color.Green, 3f);

        protected Point origin;
        public Point Origin { get => origin; set => origin = value; }

        protected Color color;

        public Color Color { get => color; set => color = value; }

        protected bool filled;
        public bool Filled { get => filled; set => filled = value; }
        public CustomSize Size { get => size; set => size = value; }

        protected bool selected;

        protected Brush colorBrush;
        protected Pen colorPen;

        protected int centerSize = 15;

        protected CustomSize size;

        public Shape(Point origin, Color color, bool filled)
        {
            this.origin = origin;
            this.color = color;
            this.filled = filled;
            this.selected = false;
            ChangeColor(color);

        }

        public abstract void Draw(Graphics g, bool drawCenters);
        
        public abstract bool ContainsPoint(Point location, out float distance);

        public abstract void ChangeSize(CustomSize size);
        public void Select(bool active)
        {
            this.selected = active;
        }
        public void ChangeColor(Color color)
        {
            this.color = color;
            colorBrush = new SolidBrush(color);
            colorPen = new Pen(color);
        }

        public abstract CustomSize CalcSize(Point location, bool keepRatio = false);

        public void ChangeFill(bool filled)
        {
            this.filled = filled;
        }

        public void ChangeY(int value)
        {
            this.origin.Y = value;
        }

        public void ChangeX(int value)
        {
            this.origin.X = value;
        }
    }
}
