using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolecka
{
    public partial class Canvas : UserControl
    {
        private List<Shape> shapes = new List<Shape>();

        private Shape selectedShape = null;

        public Shape SelectedShape => selectedShape;

        public event Action<Shape> ShapeSelected;

        private bool drawCenters = false;

        public bool DrawCenters { get => drawCenters; set { drawCenters = value; Refresh(); } }
        public Canvas()
        {
            InitializeComponent();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            foreach (var item in shapes)
            {
                item.Draw(e.Graphics,drawCenters);
            }
        }

        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
            Refresh();
        }

        private void Canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                float closestCenter = float.MaxValue;
                Shape closestShape = null;
                float currentDistance;

                foreach (var shape in shapes)
                {
                    if (shape.ContainsPoint(e.Location, out currentDistance))
                    {
                        if (currentDistance < closestCenter)
                        {
                            closestShape = shape;
                            closestCenter = currentDistance;
                        }
                    }
                }

                SelectShape(closestShape);
            }
        }

        private void SelectShape(Shape shape)
        {
            if (selectedShape != null)
            {
                selectedShape.Select(false);
            }
            selectedShape = shape;

            if (selectedShape != null)
            {
                selectedShape.Select(true);
            }
            ShapeSelected?.Invoke(shape);
            Refresh();
        }

        public void RemoveShape(Shape currentShape = null)
        {
            if(currentShape == null)
            {
                shapes.Remove(selectedShape);
                selectedShape = null;
                ShapeSelected?.Invoke(null);
            }
            else
            {
                shapes.Remove(currentShape);
            }
            Refresh();
        }

        /*public void EditCircle(decimal radius, decimal x, decimal y, Color backColor, bool fill)
        {
            selectedShape.Edit((float)(radius), (int)x, (int)y, backColor, fill);
            Refresh();  
        }*/
    }
}
