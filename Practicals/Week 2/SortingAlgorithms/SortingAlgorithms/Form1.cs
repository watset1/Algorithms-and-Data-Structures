using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithms
{
    public partial class Form1 : Form
    {
        SortMachine sm;

        public Form1()
        {
            InitializeComponent();          
        }

        private void displayArrayContents(int[] array, String sortType, bool sorted)
        {
            lblType.Text = sortType;
            if (sorted)
            {
                listBox2.Items.Add("- Sorted Numbers - ");
                foreach (int num in array)
                    listBox2.Items.Add(num);
            }
            else
            {
                
                listBox1.Items.Add("- Unsorted Numbers - ");
                foreach (int num in array)
                    listBox1.Items.Add(num);
            }           
        }

        private bool SortSetUp()
        {
            if (Math.Log((int)numberInput.Value, 2) % 1 == 0)
            {
                sm = new SortMachine((int)numberInput.Value);
                return true;
            }
            else
            {
                lblError.Visible = true;
                return false;
            }
        }

        private void btnBubble_Click(object sender, EventArgs e)
        {
            clearListBox();
            lblError.Visible = false;
            if (SortSetUp())
            {
                SortSetUp();
                displayArrayContents(sm.SortArray, "Bubble Sort", false);
                sm.BubbleSort();
                displayArrayContents(sm.SortArray, "Bubble Sort", true);
            }
        }
     
        private void btnSelection_Click(object sender, EventArgs e)
        {
            clearListBox();
            lblError.Visible = false;
            if (SortSetUp())
            {
                SortSetUp();
                displayArrayContents(sm.SortArray, "Selection Sort", false);
                sm.SelectionSort();
                displayArrayContents(sm.SortArray, "Selection Sort", true);
            }
        }

        private void btnInsertion_Click(object sender, EventArgs e)
        {
            clearListBox();
            lblError.Visible = false;
            if (SortSetUp())
            {
                SortSetUp();
                displayArrayContents(sm.SortArray, "Insertion Sort", false);
                sm.InsertionSort();
                displayArrayContents(sm.SortArray, "Insertion Sort", true);
            }
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            clearListBox();
            lblError.Visible = false;
            if (SortSetUp())
            {
                SortSetUp();
                displayArrayContents(sm.SortArray, "Merge Sort", false);
                sm.MergeSort();
                displayArrayContents(sm.SortArray, "Merge Sort", true);
            }
        }

        //Clears listboxes
        private void clearListBox()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }      
    }
}
