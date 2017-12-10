using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDC
{
    public partial class Form1 : Form
    {
        FoxDuckCornGraph graph;
        Graphics canvas;
        PictureBox[] pictures;

        public Form1()
        {
            InitializeComponent();
            canvas = this.CreateGraphics();
            createPicturesArray();
        }

        private void createPicturesArray()
        {
            pictures = new PictureBox[4];
            pictures[0] = picFarmer;
            pictures[1] = picFox;
            pictures[2] = picDuck;
            pictures[3] = picCorn;
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            graph = new FoxDuckCornGraph(16, canvas);
            graph.makeGraph();
            graph.solveGraph(listBox1, pictures);
        }


    }
}
