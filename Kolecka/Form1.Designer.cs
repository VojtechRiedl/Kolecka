namespace Kolecka
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            checkBox2 = new CheckBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            canvas1 = new Canvas();
            colorDialog1 = new ColorDialog();
            panel2 = new Panel();
            button3 = new Button();
            checkBox3 = new CheckBox();
            button2 = new Button();
            label3 = new Label();
            ynum = new NumericUpDown();
            label2 = new Label();
            xnum = new NumericUpDown();
            label1 = new Label();
            rnum = new NumericUpDown();
            title = new Label();
            colorDialog2 = new ColorDialog();
            checkBox4 = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ynum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xnum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rnum).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(checkBox4);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(checkBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1143, 75);
            panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(464, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(433, 23);
            comboBox1.TabIndex = 3;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(948, 19);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(192, 36);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Zobrazit středy";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(122, 69);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(131, 19);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(133, 36);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Vyplněný";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // canvas1
            // 
            canvas1.DrawCenters = false;
            canvas1.Location = new Point(12, 93);
            canvas1.Name = "canvas1";
            canvas1.Size = new Size(981, 597);
            canvas1.TabIndex = 1;
            canvas1.MouseDown += canvas1_MouseDown;
            canvas1.MouseMove += canvas1_MouseMove;
            canvas1.MouseUp += canvas1_MouseUp;
            // 
            // colorDialog1
            // 
            colorDialog1.Color = SystemColors.HotTrack;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(checkBox3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(ynum);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(xnum);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(rnum);
            panel2.Controls.Add(title);
            panel2.Location = new Point(1002, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(153, 597);
            panel2.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.FlatAppearance.BorderColor = Color.Red;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(28, 233);
            button3.Name = "button3";
            button3.Size = new Size(109, 42);
            button3.TabIndex = 11;
            button3.Text = "Smazat";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.Location = new Point(28, 198);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(109, 29);
            checkBox3.TabIndex = 10;
            checkBox3.Text = "Vyplněný";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Location = new Point(36, 129);
            button2.Name = "button2";
            button2.Size = new Size(101, 63);
            button2.TabIndex = 9;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 102);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 8;
            label3.Text = "Y";
            // 
            // ynum
            // 
            ynum.Location = new Point(36, 100);
            ynum.Name = "ynum";
            ynum.Size = new Size(101, 23);
            ynum.TabIndex = 7;
            ynum.ValueChanged += ynum_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 73);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 6;
            label2.Text = "X";
            // 
            // xnum
            // 
            xnum.Location = new Point(36, 71);
            xnum.Name = "xnum";
            xnum.Size = new Size(101, 23);
            xnum.TabIndex = 5;
            xnum.ValueChanged += xnum_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 44);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 4;
            label1.Text = "R";
            // 
            // rnum
            // 
            rnum.Location = new Point(36, 42);
            rnum.Name = "rnum";
            rnum.Size = new Size(101, 23);
            rnum.TabIndex = 3;
            rnum.ValueChanged += rnum_ValueChanged;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(17, 14);
            title.Name = "title";
            title.Size = new Size(67, 25);
            title.TabIndex = 0;
            title.Text = "Label1";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox4.Location = new Point(270, 21);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(132, 34);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "Keep Ratio";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 702);
            Controls.Add(panel2);
            Controls.Add(canvas1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ynum).EndInit();
            ((System.ComponentModel.ISupportInitialize)xnum).EndInit();
            ((System.ComponentModel.ISupportInitialize)rnum).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Canvas canvas1;
        private Button button1;
        private CheckBox checkBox1;
        private ColorDialog colorDialog1;
        private CheckBox checkBox2;
        private Panel panel2;
        private Label title;
        private CheckBox checkBox3;
        private Button button2;
        private Label label3;
        private NumericUpDown ynum;
        private Label label2;
        private NumericUpDown xnum;
        private Label label1;
        private NumericUpDown rnum;
        private Button button3;
        private ColorDialog colorDialog2;
        private ComboBox comboBox1;
        private CheckBox checkBox4;
    }
}