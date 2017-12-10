using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueueLiveCoding
{
    public class Patient
    {
        public String Name { get; set; }
        public int Priority { get; set; }

        public Patient(String Name, int Priority) 
        {
            this.Name = Name;
            this.Priority = Priority;
        }
    }
}
