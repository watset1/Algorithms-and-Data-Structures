using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        Graphics canvas;

        public Form1()
        {
            InitializeComponent();
            canvas = this.CreateGraphics();
            canvas.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            canvas.FillRectangle((new SolidBrush(Color.White)), 0, 0, Width, Height);
            FractalMachine fm = new FractalMachine(canvas);
            if (rdoTriangle.Checked)
                fm.Triangle((int)numericUpDown1.Value, new Point(700, 100), new Point(1000, 600), new Point(400, 600));
            if (rdoSnowflake.Checked)
            {                
                fm.Snowflake((int)numericUpDown1.Value, new Point(400, 500), new Point(1000, 500));
                fm.Snowflake((int)numericUpDown1.Value, new Point(1000, 500), new Point(700, 0));
                fm.Snowflake((int)numericUpDown1.Value, new Point(700, 0), new Point(400, 500));
            }
            if (rdoTree.Checked)
                fm.Tree((int)numericUpDown1.Value, (int)numericUpDown1.Value, new Point(700, 600), 150, -90, 45, 8);
            if (rdoDragon.Checked)
                fm.Dragon((int)numericUpDown1.Value, new Point(950, 300), new Point(-400, 0), EDirection.left);
            if (rdoCircle.Checked)
            {
                fm.Circle((int)numericUpDown1.Value, new Point(400, 25), 600);
            }
                
        }


    }
}
