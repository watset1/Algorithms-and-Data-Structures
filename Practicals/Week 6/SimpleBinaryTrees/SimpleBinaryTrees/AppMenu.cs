using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBinaryTrees
{
    public partial class AppMenu : Form
    {
        Practical1 prac1;
        Practical2 prac2;

        public AppMenu()
        {
            InitializeComponent();                     
        }

        private void btnPrac1_Click(object sender, EventArgs e)
        {
            prac1 = new Practical1(this);
            prac1.Show();
            this.Hide();
        }

        private void btnPrac2_Click(object sender, EventArgs e)
        {
            prac2 = new Practical2(this);
            prac2.Show();
            this.Hide();
        }
    }
}
