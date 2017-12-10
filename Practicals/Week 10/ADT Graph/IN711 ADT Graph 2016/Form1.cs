using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IN711_ADT_Graph_2016
{
    public partial class Form1 : Form
    {
        Graphics canvas;
        Graph mainGraph;
        public Form1()
        {
            InitializeComponent();
            canvas = this.CreateGraphics();                                
        }

        private void createDemoGraph()
        {
            mainGraph = new Graph(16, canvas);
            mainGraph.makeDemoGraph();
            mainGraph.drawGraph();
            mainGraph.traverseGraph(listBox1);
        } 
  
        private void createExampleGraph()
        {
            mainGraph = new Graph(7, canvas);
            mainGraph.makeExampleGraph();
            mainGraph.drawGraph();
            mainGraph.traverseGraph(listBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //createExampleGraph();
            createDemoGraph();
        }

    }// end Form class
} // end namespace
