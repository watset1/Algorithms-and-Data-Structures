using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADT_Tables
{
    public partial class Form1 : Form
    {
        HashTable fileTable;
        HashTable chainingHashTable;
        HashTable doubleHashTable;
        HashTable hashTable;

        public Form1()
        {
            InitializeComponent();
            CreateHashTables();
        }

        private void CreateHashTables()
        {
            chainingHashTable = new HashTable(17);
            doubleHashTable = new HashTable(17);
            hashTable = new HashTable(17);

            Node node1 = new Node(7, "Bob", "Tiger", 12, 3, "Zebra");
            Node node2 = new Node(15, "Fred", "Chimpanzee", 3, 9, "Bananas");
            Node node3 = new Node(6, "Agnes", "Lion", 5, 6, "Zebra");
            Node node4 = new Node(58, "Piper", "Pidgeon", 7, 1, "Seed");
            Node node5 = new Node(92, "Candace", "Llama", 9, 4, "Grass");

            chainingHashTable.InsertItem(node1, EHashType.chaining);
            chainingHashTable.InsertItem(node2, EHashType.chaining);
            chainingHashTable.InsertItem(node3, EHashType.chaining);
            chainingHashTable.InsertItem(node4, EHashType.chaining);
            chainingHashTable.InsertItem(node5, EHashType.chaining);

            doubleHashTable.InsertItem(node1, EHashType.doubleHash);
            doubleHashTable.InsertItem(node2, EHashType.doubleHash);
            doubleHashTable.InsertItem(node3, EHashType.doubleHash);
            doubleHashTable.InsertItem(node4, EHashType.doubleHash);
            doubleHashTable.InsertItem(node5, EHashType.doubleHash);

            hashTable.InsertItem(node1, EHashType.singleHash);
            hashTable.InsertItem(node2, EHashType.singleHash);
            hashTable.InsertItem(node3, EHashType.singleHash);
            hashTable.InsertItem(node4, EHashType.singleHash);
            hashTable.InsertItem(node5, EHashType.singleHash);
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            fileTable = new HashTable(100);
            chainingHashTable = new HashTable(100);
            doubleHashTable = new HashTable(100);
            hashTable = new HashTable(100);
            OpenFileDialog fileBrowserDialog = new OpenFileDialog();
            fileBrowserDialog.Filter = "CSV files (.csv)|*.csv|Text Files (.txt)|*.txt";

            DialogResult result = fileBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                String filename = fileBrowserDialog.FileName;
                fileTable.LoadFromFile(filename);
                chainingHashTable.LoadFromFile(filename);
                doubleHashTable.LoadFromFile(filename);
                hashTable.LoadFromFile(filename);
            }
            displayTable(chainingHashTable);
        }

        private void displayTable(Table table) //Can be very table specific i.e whatever the table is holding 
        {
            clearGrid();
            DataGridViewRowCollection gridRows = dataGridView1.Rows;
            for (int i = 0; i < fileTable.Nodes.Length; i++)
            {
                if (fileTable.Nodes[i] != null)
                {
                    int id = fileTable.Nodes[i].Id; //Depending on what the table is holding
                    String name = fileTable.Nodes[i].Name;
                    String species = fileTable.Nodes[i].Species;
                    int cageNumber = fileTable.Nodes[i].CageNumber;
                    int age = fileTable.Nodes[i].Age;
                    String food = fileTable.Nodes[i].Food;
                    gridRows.Add(id, name, species, cageNumber, age, food);
                }
            }
        }

        private void displayNode(Node node)
        {
            clearGrid();
            DataGridViewRowCollection gridRows = dataGridView1.Rows;
            if (node != null)
            {
                int id = node.Id; //Depending on what the table is holding
                String name = node.Name;
                String species = node.Species;
                int cageNumber = node.CageNumber;
                int age = node.Age;
                String food = node.Food;
                gridRows.Add(id, name, species, cageNumber, age, food);
            }
        }
       
        private void clearGrid()
        {
            dataGridView1.Rows.Clear();
        }

        private void btnHash_Click(object sender, EventArgs e)
        {          
            displayNode(hashTable.FindItem((int)numericUpDown1.Value, EHashType.singleHash));
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            displayNode(doubleHashTable.FindItem((int)numericUpDown1.Value, EHashType.doubleHash));
        }

        private void btnChain_Click(object sender, EventArgs e)
        {
            displayNode(chainingHashTable.FindItem((int)numericUpDown1.Value, EHashType.chaining));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Simulation simulation = new Simulation();
            simulation.Run();
        }
    }
}
