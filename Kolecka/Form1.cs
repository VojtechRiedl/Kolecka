using System.Reflection;

namespace Kolecka
{
    public partial class Form1 : Form
    {
        private ShapeFactory factory = new ShapeFactory();

        private bool holdingMouseButton = false;
        private Shape currentShape = null;

        public Form1()
        {
            InitializeComponent();
            rnum.Maximum = (int)Math.Sqrt(canvas1.Width * canvas1.Width + canvas1.Height * canvas1.Height);
            xnum.Maximum = canvas1.Width;
            ynum.Maximum = canvas1.Height;
            factory.filled = checkBox1.Checked;
            factory.color = colorDialog1.Color;
            panel2.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Type ShapeType = typeof(Shape);
            var types = Assembly.GetAssembly(ShapeType)
                .GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(ShapeType))
                .ToList();

            foreach (var item in types)
            {
                comboBox1.Items.Add(item.Name);
            }

            comboBox1.SelectedIndex = 0;

        }

        private void canvas1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                holdingMouseButton = true;
                currentShape = factory.CreateShape(Type.GetType("Kolecka." + comboBox1.SelectedItem), e.Location);
                canvas1.AddShape(currentShape);
                canvas1.ShapeSelected += OnShapeSelected;
            }
        }

        private void OnShapeSelected(Shape shape)
        {
            if (shape == null)
            {
                panel2.Hide();
            }
            else
            {
                panel2.Show();
                //rnum.Value = (int)shape.Radius;
                xnum.Value = shape.Origin.X;
                ynum.Value = shape.Origin.Y;
                button2.BackColor = shape.Color;
                checkBox3.Checked = shape.Filled;
            }
        }

        private void canvas1_MouseMove(object sender, MouseEventArgs e)
        {
            if (holdingMouseButton)
            {
                if (e.Location.X < 0 || e.Location.X > canvas1.Width || e.Location.Y < 0 || e.Location.Y > canvas1.Height)
                {
                    canvas1.RemoveShape(currentShape);
                    currentShape = null;
                    holdingMouseButton = false;
                    canvas1.Refresh();
                    return;
                }

                currentShape.ChangeSize(currentShape.CalcSize(e.Location, checkBox4.Checked));
                Refresh();
            }
        }

        private void canvas1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                holdingMouseButton = false;
                currentShape = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
                factory.color = colorDialog1.Color;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            factory.filled = checkBox1.Checked;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            canvas1.RemoveShape();
        }

        private void rnum_ValueChanged(object sender, EventArgs e)
        {
            //canvas1.SelectedShape?.ChangeSize((float)rnum.Value);
            //canvas1.Refresh();
        }

        private void xnum_ValueChanged(object sender, EventArgs e)
        {
            canvas1.SelectedShape?.ChangeX((int)xnum.Value);
            canvas1.Refresh();
        }

        private void ynum_ValueChanged(object sender, EventArgs e)
        {
            canvas1.SelectedShape?.ChangeY((int)ynum.Value);
            canvas1.Refresh();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            canvas1.SelectedShape?.ChangeFill(checkBox3.Checked);
            canvas1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = colorDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                button2.BackColor = colorDialog2.Color;
                canvas1.SelectedShape?.ChangeColor(colorDialog2.Color);
                canvas1.Refresh();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            canvas1.DrawCenters = checkBox2.Checked;
        }


    }
}