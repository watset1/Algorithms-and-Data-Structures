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

namespace Genetic_Algorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int pop = Convert.ToInt32(txtPop.Text);
            double keep = Convert.ToDouble(txtKeep.Text);
            double mutation = Convert.ToDouble(txtMutation.Text);
            ExampleGA exampleGA = new ExampleGA(pop, keep, mutation);
            exampleGA.RunAlgorithm(listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int pop = Convert.ToInt32(txtPop.Text);
            double keep = Convert.ToDouble(txtKeep.Text);
            double mutation = Convert.ToDouble(txtMutation.Text);
            DigitSequenceGA dsga = new DigitSequenceGA(pop, keep, mutation);
            dsga.RunAlgorithm(listBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int pop = Convert.ToInt32(txtPop.Text);
            double keep = Convert.ToDouble(txtKeep.Text);
            double mutation = Convert.ToDouble(txtMutation.Text);
            AlgebraGA aga = new AlgebraGA(pop, keep, mutation);
            aga.RunAlgorithm(listBox1);
        }

        private void btnKnapsack_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int pop = Convert.ToInt32(txtPop.Text);
            double keep = Convert.ToDouble(txtKeep.Text);
            double mutation = Convert.ToDouble(txtMutation.Text);
            KnapsackGA ksga = new KnapsackGA(pop, keep, mutation);
            ksga.RunAlgorithm(listBox1);
        }

        private void btnBatch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int pop = Convert.ToInt32(txtPop.Text);
            double keep = Convert.ToDouble(txtKeep.Text);
            double mutation = Convert.ToDouble(txtMutation.Text);
            for (int i = 0; i < 100; i++)
            {
                KnapsackGA ksga = new KnapsackGA(pop, keep, mutation);
                ksga.RunAlgorithm(listBox1);
            }
        }
    }
}
