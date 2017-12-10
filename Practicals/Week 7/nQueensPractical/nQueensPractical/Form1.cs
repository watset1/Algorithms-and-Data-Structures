using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nQueensPractical
{
    public partial class Form1 : Form
    {
        nQueensTree qt;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTree_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            listBox1.Items.Clear();
            qt = new nQueensTree((int)spinBoxQueens.Value);
            qt.TreeGenerator(ref qt.rootNode, 0);
            qt.PrintTree(qt.rootNode, listBox1);
            Cursor.Current = Cursors.Default;
        }

        private void btnSolutions_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; 
            listBox1.Items.Clear();
            qt = new nQueensTree((int)spinBoxQueens.Value);
            qt.TreeGenerator(ref qt.rootNode, 0);
            qt.PrintSolutions(qt.rootNode, listBox1);
            Cursor.Current = Cursors.Default;
        }

        private void btnPruned_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            listBox1.Items.Clear();
            qt = new nQueensTree((int)spinBoxQueens.Value);
            qt.PrunedTreeGenerator(ref qt.rootNode, 0);
            qt.PrintTree(qt.rootNode, listBox1);
            Cursor.Current = Cursors.Default;
        }       
    }
}
