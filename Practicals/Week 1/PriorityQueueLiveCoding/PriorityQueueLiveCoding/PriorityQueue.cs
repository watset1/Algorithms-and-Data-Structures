using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriorityQueueLiveCoding
{
    public class PriorityQueue
    {
        const int ARRAYLENGTH = 100;
        const int EMPTY = 0;

        Patient[] patients;
        int highestPriority;
        int patientCount;

        public PriorityQueue()
        {
            patients = new Patient[ARRAYLENGTH];
            highestPriority = 0;
        }

        public void Push(Patient patient)
        {
            bool added = false;
            if (count().Equals(ARRAYLENGTH))
                MessageBox.Show("Patient list is full. Please remove patients before adding more.");
            else
            {
                for (int i = 0; i < ARRAYLENGTH; i++)
			    {
                    if (patients[i] == null && added == false)
                    {
                        patients[i] = patient;
                        if (patient.Priority > highestPriority)
                            highestPriority = patient.Priority;
                        added = true;
                    }			        
                }
            }
        }

        public Patient Pop()
        {
            bool popped = false;
            Patient patient = null;
            if (count().Equals(EMPTY))
            {
                MessageBox.Show("Patient list is empty. In order to Pop from the queue there must be patients in the list.");
                
            }
            else
                for (int i = 0; i < ARRAYLENGTH; i++)
                {
                    if (patients[i] != null && popped == false)
                    {
                        if (patients[i].Priority == highestPriority)
                        {
                            patient = patients[i];
                            patients[i] = null;
                            popped = true;
                        }
                    }
                }
            setHighestPriority();
            return patient;                                
        }

        public void Print(ListBox listBox)
        {
            listBox.Items.Add("Name" + " : " + "Priority");
            foreach (Patient patient in patients)
                if(patient != null)
                    listBox.Items.Add(patient.Name + " : " + patient.Priority);
        }

        private int count()
        {
            patientCount = 0;
            foreach (Patient patient in patients)
                if (patient != null)
                    patientCount++;
            return patientCount;
        }

        private void setHighestPriority()
        {
            highestPriority = 0;
            for (int i = 0; i < ARRAYLENGTH; i++)
            {
                if (patients[i] != null)
                    if (patients[i].Priority > highestPriority)
                        highestPriority = patients[i].Priority;
            }
                
        }
    }
}
