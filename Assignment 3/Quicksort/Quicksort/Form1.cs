using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quicksort
{
    /*
     *Quicksort functionality: 
     * Quicksort splits a list of numbers into smaller parts that are created around correctly 
     * sorted numbers. One value in each smaller part is then sorted and then split again into 
     * smaller part(s). This continues until the smaller parts only consists of one number.
     */
     
    public partial class Form1 : Form
    {
        SortManager manager;

        public Form1()
        {
            InitializeComponent();
            manager = new SortManager();
        }

        //Sort button
        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            lstUnsorted.Items.Clear();
            rchSorted.Clear();
            int setSize = (int)nupSetSize.Value;
            manager.Quicksort(setSize, lstUnsorted, rchSorted);         
        }      
    }
}
