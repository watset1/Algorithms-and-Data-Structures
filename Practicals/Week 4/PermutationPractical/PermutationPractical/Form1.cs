using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PermutationPractical
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PermutationAlgorithm pa = new PermutationAlgorithm(0, (int)numericUpDown1.Value);
            listBox1.Items.Clear();
            foreach (String record in pa.intToStringArray)
                listBox1.Items.Add(record);
        }
    }
}
