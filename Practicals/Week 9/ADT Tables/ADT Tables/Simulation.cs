using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT_Tables
{
    public class Simulation
    {
        const int TABLESIZE = 8629;
        const int SAMPLESIZE = 100000;
        const int RUNCOUNT = 100;

        List<double> linearProbing;
        List<double> doubleHashing;
        List<double> chaining;
        HashTable linearProbeTable;
        HashTable doubleHashTable;
        HashTable chainTable;
        List<Node> randomNodes;
        List<int> randomNumbers;
        Random random;
        
        public Simulation()
        {
            linearProbing = new List<double>();
            doubleHashing = new List<double>();
            chaining = new List<double>();                                    
            random = new Random();                       
        }

        public void Run()
        {
            RunMultipleSimulations(RUNCOUNT);
            GenerateOutput();
        }

        public void RunMultipleSimulations(int runCount)
        {
            
            DateTime d1;
            DateTime d2;
            DateTime d3;
            DateTime d4;
            DateTime d5;
            DateTime d6;
            for (int run = 0; run < runCount; run++)
            {
                randomNodes = new List<Node>();
                randomNumbers = new List<int>();
                linearProbeTable = new HashTable(TABLESIZE);
                doubleHashTable = new HashTable(TABLESIZE);
                chainTable = new HashTable(TABLESIZE);
                for (int i = 0; i < TABLESIZE - 1; i++)
                {
                    GenerateRandomNode();
                }
                
                AddNodesToTable();

                d1 = DateTime.Now;
                for (int index = 0; index < randomNumbers.Count(); index++)
                    RunLinearSimulation(randomNumbers[index]);
                d2 = DateTime.Now;
                linearProbing.Add(CalculateMilliseconds(d2, d1));

                d3 = DateTime.Now;
                for (int index = 0; index < randomNumbers.Count(); index++)
                    RunDoubleSimulation(randomNumbers[index]);
                d4 = DateTime.Now;
                doubleHashing.Add(CalculateMilliseconds(d4, d3));

                d5 = DateTime.Now;
                for (int index = 0; index < randomNumbers.Count(); index++)
                    RunChainSimulation(randomNumbers[index]);
                d6 = DateTime.Now;
                chaining.Add(CalculateMilliseconds(d6, d5));
            }          
        }

        public void RunLinearSimulation(int randomNumber)
        {                            
            linearProbeTable.FindItem(randomNumber, EHashType.singleHash);
        }

        public void RunDoubleSimulation(int randomNumber)
        {
            doubleHashTable.FindItem(randomNumber, EHashType.doubleHash);
        }

        public void RunChainSimulation(int randomNumber)
        {
            chainTable.FindItem(randomNumber, EHashType.chaining);
        }

        public void GenerateRandomNode()
        {
            int rGen = random.Next(SAMPLESIZE);
            randomNodes.Add(new Node(rGen, "", "", 0, 0, ""));
            randomNumbers.Add(rGen);
        }

        public void AddNodesToTable()
        {
            for (int index = 0; index < TABLESIZE - 1; index++)
            {
                linearProbeTable.InsertItem(randomNodes[index], EHashType.singleHash);
                doubleHashTable.InsertItem(randomNodes[index], EHashType.doubleHash);
                chainTable.InsertItem(randomNodes[index], EHashType.chaining);
            }
        }

        public double CalculateMilliseconds(DateTime d1, DateTime d2)
        {
            return (d1 - d2).TotalMilliseconds;
        }
        
        public void GenerateOutput()
        {
            StreamWriter sr = new StreamWriter("Output-" + RUNCOUNT + ".txt");
            sr.WriteLine("Linear probing times:");
            foreach (double number in linearProbing)
                sr.WriteLine(number.ToString());
            sr.WriteLine("Double Hash times:");
            foreach (double number in doubleHashing)
                sr.WriteLine(number.ToString());
            sr.WriteLine("Chaining times:");
            foreach (double number in chaining)
                sr.WriteLine(number.ToString());
            sr.Close();
        }
    }
}
