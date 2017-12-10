using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordLadderApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            lstLadder.Items.Clear();
            String startWord = txtStart.Text.ToLower();
            String targetWord = txtTarget.Text.ToLower();
            WordLadder.BuildLadder(startWord, targetWord, lstLadder);
        }

        private void txtStart_TextChanged(object sender, EventArgs e)
        {
            btnRun.Enabled = validTextBoxes();
        }

        private void txtTarget_TextChanged(object sender, EventArgs e)
        {
            btnRun.Enabled = validTextBoxes();
        }

        private bool validTextBoxes()
        {
            if (txtStart.Text.Length == 5 && txtTarget.Text.Length == 5 && !txtStart.Text.Equals(txtTarget.Text))
                return true;
            else
                return false;
        }
    }
}
