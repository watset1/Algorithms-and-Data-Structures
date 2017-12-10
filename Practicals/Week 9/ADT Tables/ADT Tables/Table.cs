using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADT_Tables
{
    public class Table
    {
        public Node[] Nodes { get; set; } //Possibly add IEnumerable

        public Table() { }

        public Table(int tableSize) 
        {
            Nodes = new Node[tableSize];
        }

        //Insert a node into the nodes position in the id field of the given node
        public void InsertItem(Node node)
        {
            Nodes[node.Id] = node;
        }

        //Returns the Node int he node key index position
        public Node FindItem(int key)
        {
            return Nodes[key];
        }

        //Inserts nodes into the node array using the split file values
        public void LoadFromFile(String filename)
        {
            StreamReader sr = new StreamReader(filename);
            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();
                String[] cells = line.Split(',');
                int id = Convert.ToInt32(cells[0]);
                String name = cells[1];
                String species = cells[2];
                int cageNumber = Convert.ToInt32(cells[3]);
                int age = Convert.ToInt32(cells[4]);
                String food = cells[5];
                InsertItem(new Node(id, name, species, cageNumber, age, food));
            }
        }
    }
}
