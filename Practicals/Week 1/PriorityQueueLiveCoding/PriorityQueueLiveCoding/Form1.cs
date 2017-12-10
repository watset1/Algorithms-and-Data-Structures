using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriorityQueueLiveCoding
{
    public partial class Form1 : Form
    {
        PriorityQueue grommetChildren;
        List<Patient> patientList;

        public Form1()
        {
            InitializeComponent();
            grommetChildren = new PriorityQueue();
            seedPatients();
        }

        private void seedPatients()
        {
            patientList = new List<Patient>{
                new Patient("Bobby", 10),
                new Patient("Freddy", 7),
                new Patient("George", 7),
                new Patient("Ashleigh", 5)
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Patient patient in patientList)
                grommetChildren.Push(patient);
            grommetChildren.Print(listBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Patient patient = grommetChildren.Pop();
            MessageBox.Show(patient.Name + " : " + patient.Priority);
            grommetChildren.Print(listBox1);
        }

       


        
        
    }
}
