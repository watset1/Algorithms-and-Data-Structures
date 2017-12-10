using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT_Tables
{
    public class Node
    {
        public Node Next { get; set; }
        public int Id { get; set; }
        public String Name {get; set; }
        public String Species { get; set; }
        public int CageNumber { get; set; }
        public int Age { get; set; }
        public String Food { get; set; }

        public Node(int id, String name, String species, int cageNumber, int age, String food)
        {
            Next = null;
            Id = id;
            Name = name;
            Species = species;
            CageNumber = cageNumber;
            Age = age;
            Food = food;
        }
    }
}
