using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genetic_Algorithms
{
    public enum EGoalType { Fitness, Cost }
    public abstract class GABaseEngine
    {
        protected const int ELITISM = 1; //Value deciding how many chromosomes are safe from mutation

        protected EChromosomeType chromosomeType;
        protected EGoalType goalType;
        protected int fitnessGoal;
        protected int costGoal;
        protected int populationSize;
        protected int keptPopulation;
        protected int childrenNeeded;
        protected int generation;
        protected int currentFittest;
        protected bool fittestChange;
        protected int geneAmount; // Will be given a value when Fitness Function is called in the child class
        protected int lowRange; //Will also be given a value when Fitness Function is called in the child class
        protected int highRange; //Will also be given a value when Fitness Function is called in the child class
        protected int fitnessValue; //Will also be given a value when Fitness Function is called in the child class
        protected double keep, mutation;
        protected Chromosome[] population;
        protected Chromosome father;
        protected Chromosome mother;
        protected Chromosome child1;
        protected Chromosome child2;
        protected Chromosome fittest;
        protected Random random;

        public GABaseEngine(int populationSize, double keep, double mutation)
        {
            this.populationSize = populationSize;          
            this.keep = keep;
            this.mutation = mutation;
            keptPopulation = Convert.ToInt16(populationSize * keep);
            random = new Random();
            generation = 0;
            currentFittest = 0;
            fittestChange = true;
        }

        public abstract void EncodeSolution(); //Generate Chromosomes etc 

        public abstract void FitnessFunction(); //Compute the fitness/cost for each chromosome, sort population by fitness score, rank invertedly, keep a percentage of the population (double keep)???

        public void SortPopulation()
        {
            Chromosome heldValue; //Holds the array value being compared
            int currentIndex; //The current index 
            for (int i = 1; i < populationSize; i++)
            {
                heldValue = population[i]; //Stores the value where the first number may be shifted to
                currentIndex = i - 1;
                if (goalType.Equals(EGoalType.Cost))
                    SortByCost(ref currentIndex, ref heldValue);
                else
                    SortByFitness(ref currentIndex, ref heldValue);
                population[currentIndex + 1] = heldValue; //Replaces value where the decending while loop ended with the held value 
            }
        }

        public void SortByCost(ref int currentIndex, ref Chromosome heldValue)
        {
            while (currentIndex >= 0 && population[currentIndex].Fitness > heldValue.Fitness) //Goes down each array index shifting larger values up until values are no longer larger or 0 index position has been reached
            {
                //If the next value is less than the current value being compared the current value will be shifted up one space
                population[currentIndex + 1] = population[currentIndex];
                currentIndex--;
            }
        }

        public void SortByFitness(ref int currentIndex, ref Chromosome heldValue)
        {
            while (currentIndex >= 0 && population[currentIndex].Fitness < heldValue.Fitness) //Goes down each array index shifting larger values up until values are no longer larger or 0 index position has been reached
            {
                //If the next value is less than the current value being compared the current value will be shifted up one space
                population[currentIndex + 1] = population[currentIndex];
                currentIndex--;
            }
        }

        //Population is ranked by array index order after previously being sorted by fitness
        public void RankPopulation()
        {
            for (int index = 0; index < keptPopulation; index++)
                population[index].Rank = keptPopulation - index;
        }

        //Compute each chromosomes cumulative probability of being selected
        public void ComputeProbabilities()
        {
            int rankTotal = 0;
            //Calculate sum of all ranks
            for (int rank = 0; rank < keptPopulation; rank++)
                rankTotal += rank + 1;
            //Set each chromosomes cumulative probablility based on their rank
            for (int index = 0; index < keptPopulation; index++)
                if (index == 0)
                    population[index].CumulativeProb = Math.Round(Convert.ToDouble(population[index].Rank) / rankTotal, 1); 
                else
                    population[index].CumulativeProb =  Math.Round(Convert.ToDouble(population[index].Rank) / rankTotal + Convert.ToDouble(population[index - 1].CumulativeProb), 1);
        }
        
        public void RunAlgorithm(ListBox listBox)
        {
            EncodeSolution();
            FitnessFunction();
            if (goalType.Equals(EGoalType.Cost))
                RunCostFunctions(listBox);
            else
                RunFitnessFunctions(listBox);
        }

        public void RunCostFunctions(ListBox listBox)
        {
            while (fitnessValue > costGoal)
            {
                SelectionReproductionMutation(listBox);
            }
        }

        public void RunFitnessFunctions(ListBox listBox)
        {
            while (generation < fitnessGoal)
            {
                SelectionReproductionMutation(listBox);
            }
            DisplayBestChromosome(listBox);
            PrintToFile();
        }

        public void SelectionReproductionMutation(ListBox listBox)
        {
            generation++;
            RankPopulation();
            ComputeProbabilities();
            childrenNeeded = populationSize - keptPopulation;
            while (childrenNeeded > 0)
            {
                Selection();
                Reproduction();
            }
            MutatePopulation();
            FitnessFunction();
            if (fittestChange)
                DisplayBestChromosome(listBox);
        }

        //Parent selection by roulette wheel
        public void Selection()
        {
            father = RouletteWheelSelection();
            while (mother == null || mother == father)
            {
                mother = RouletteWheelSelection();
            }
        }

        public Chromosome RouletteWheelSelection()
        {
            Chromosome parent = ChromosomeFactory.CreateChromosome(chromosomeType, geneAmount); ;
            //Select Parent
            //Generate random number between 0 and 100
            double probabilityRange = random.NextDouble();
            //Parent whose "bucket" is landed on is chosen based on cumulative probability
            for (int index = 0; index < keptPopulation; index++)
            {
                if (index == 0)
                {
                    if (probabilityRange > 0 && probabilityRange <= population[index].CumulativeProb)
                        parent = population[index];
                }
                else
                    if (probabilityRange > population[index - 1].CumulativeProb && probabilityRange <= population[index].CumulativeProb)
                        parent = population[index];
            }

            return parent;
        }

        public void Reproduction()
        {           
                BreedChildren();
                AddChildrenToPopulation();
                ResetParents();
        }

        public void BreedChildren()
        {
            child1 = ChromosomeFactory.CreateChromosome(chromosomeType, geneAmount);
            child2 = ChromosomeFactory.CreateChromosome(chromosomeType, geneAmount);
            //Randomly generate "crossover point"
            int crossoverPoint = random.Next(1, father.Genes.Count);
            //Generate children by swapping tails
            for (int index = 0; index < father.Genes.Count; index++)
            {
                if (index < crossoverPoint)
                {
                    child1.Genes[index] = father.Genes[index];
                    child2.Genes[index] = mother.Genes[index];
                }
                else
                {
                    child1.Genes[index] = mother.Genes[index];
                    child2.Genes[index] = father.Genes[index];
                }
            }
        }

        //Children are added (if needed) to the population based on the amount of children still needed in the population array
        public void AddChildrenToPopulation()
        {
            if (childrenNeeded > 0)
            {
                population[keptPopulation + (childrenNeeded - 1)] = child1;
                childrenNeeded--;
            }
            if (childrenNeeded > 0)
            {
                population[keptPopulation + (childrenNeeded - 1)] = child2;
                childrenNeeded--;
            }
        }

        //Nulls the parents for next reproductive iteration
        public void ResetParents()
        {
            father = null;
            mother = null;
        }

        public void MutatePopulation()
        {
            //Randomly mutate one of the chromosomes genes in a proportion of the population dependant on the double mutation
            //Dont allow the fittest chromosome to be mutated
            int numberOfMutations = Convert.ToInt32(populationSize * mutation);
            for (int i = 0; i < numberOfMutations; i++)
                population[random.Next(ELITISM, populationSize)].MutateGene(random, lowRange, highRange);          
        }

        //Stores the fittest chromosome for display purposes
        public void SetFittestChromosome()
        {
            fitnessValue = population[0].Fitness;
            fittest = population[0];
            if (currentFittest > population[0].Fitness)
                fittestChange = true;
            currentFittest = population[0].Fitness;
        }

        //Displays the fittest chromosome fitness value, generation and genes to a listbox
        public void DisplayBestChromosome(ListBox listBox)
        {
            String chromosomeString = "";
            foreach (int item in fittest.Genes)
                chromosomeString += item + " ";

            listBox.Items.Add(generation + "   " + chromosomeString + "    " + fitnessValue);
            fittestChange = false; //reset change boolean
        }

        public void PrintToFile()
        {
            using (StreamWriter writer =
            new StreamWriter("iterations.txt", true))
            {
                writer.WriteLine(fitnessValue);
                
            }
        }
    }
}
