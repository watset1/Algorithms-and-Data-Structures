using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithms
{
    public class KnapsackGA : GABaseEngine
    {
        const int SEQUENCE_LENGTH = 16;
        const int DIGIT_LOW_RANGE = 0;
        const int DIGIT_HIGH_RANGE = 2;
        const int FITNESS_GOAL = 20000; //number of generations before exiting loop 
        const int CAPACITY = 100;

        public Item[] ItemList { get; set; }

        public KnapsackGA(int populationSize, double keep, double mutation)
            : base(populationSize, keep, mutation) 
        {
            fitnessGoal = FITNESS_GOAL;
            goalType = EGoalType.Fitness;
            chromosomeType = EChromosomeType.Int;
            geneAmount = SEQUENCE_LENGTH;
            lowRange = DIGIT_LOW_RANGE;
            highRange = DIGIT_HIGH_RANGE;
            population = ChromosomeFactory.CreateChromosomeArray(chromosomeType, populationSize);
            Populate16ItemList();
        }

        public void Populate16ItemList()
        {
            ItemList = new Item[SEQUENCE_LENGTH];
            ItemList[0] = new Item(1, 74, 36);
            ItemList[1] = new Item(2, 94, 10);
            ItemList[2] = new Item(3, 54, 37);
            ItemList[3] = new Item(4, 94, 17);
            ItemList[4] = new Item(5, 95, 11);
            ItemList[5] = new Item(6, 58, 20);
            ItemList[6] = new Item(7, 26, 3);
            ItemList[7] = new Item(8, 11, 40);
            ItemList[8] = new Item(9, 39, 45);
            ItemList[9] = new Item(10, 42, 4);
            ItemList[10] = new Item(11, 66, 44);
            ItemList[11] = new Item(12, 41, 27);
            ItemList[12] = new Item(13, 83, 17);
            ItemList[13] = new Item(14, 25, 44);
            ItemList[14] = new Item(15, 49, 15);
            ItemList[15] = new Item(16, 54, 2);
        }

        public void Populate32ItemList()
        {
            ItemList = new Item[SEQUENCE_LENGTH];
            ItemList[0] = new Item(1, 64, 8);
            ItemList[1] = new Item(2, 37, 6);
            ItemList[2] = new Item(3, 9, 8);
            ItemList[3] = new Item(4, 56, 2);
            ItemList[4] = new Item(5, 26, 9);
            ItemList[5] = new Item(6, 94, 4);
            ItemList[6] = new Item(7, 28, 8);
            ItemList[7] = new Item(8, 31, 8);
            ItemList[8] = new Item(9, 85, 4);
            ItemList[9] = new Item(10, 84, 4);
            ItemList[10] = new Item(11, 29, 5);
            ItemList[11] = new Item(12, 45, 6);
            ItemList[12] = new Item(13, 67, 1);
            ItemList[13] = new Item(14, 49, 8);
            ItemList[14] = new Item(15, 10, 6);
            ItemList[15] = new Item(16, 69, 12);
            ItemList[16] = new Item(17, 42, 7);
            ItemList[17] = new Item(18, 7, 5);
            ItemList[18] = new Item(19, 96, 9);
            ItemList[19] = new Item(20, 72, 3);
            ItemList[20] = new Item(21, 1, 8);
            ItemList[21] = new Item(22, 21, 2);
            ItemList[22] = new Item(23, 92, 7);
            ItemList[23] = new Item(24, 53, 5);
            ItemList[24] = new Item(25, 92, 6);
            ItemList[25] = new Item(26, 93, 3);
            ItemList[26] = new Item(27, 32, 9);
            ItemList[27] = new Item(28, 55, 10);
            ItemList[28] = new Item(29, 74, 1);
            ItemList[29] = new Item(30, 21, 3);
            ItemList[30] = new Item(31, 72, 7);
            ItemList[31] = new Item(32, 1, 8);
        }

        public override void EncodeSolution()
        {
            for (int index = 0; index < populationSize; index++)
            {
                bool legal = false;
                population[index] = ChromosomeFactory.CreateChromosome(EChromosomeType.Int, geneAmount);
                while(!legal)
                {

                    population[index].PopulateChromosome(random, lowRange, highRange);
                    int combinedWeight = 0;
                    for (int i = 0; i < geneAmount; i++)
			        {
			            if(((int)population[index].Genes[i]) == 1)
                            combinedWeight += ItemList[i].Weight;
                    }
                    if (combinedWeight > CAPACITY)
                        legal = false;
                    else
                        legal = true;
                }
            }
        }

        public override void FitnessFunction()
        {
            SetFitnessValues();
            SortPopulation();
            SetFittestChromosome();
        }

        public void SetFitnessValues()
        {
            for (int popIndex = 0; popIndex < populationSize; popIndex++)
            {
                int fitVal = 0;
                int combinedWeight = 0;
                for (int chromosomeIndex = 0; chromosomeIndex < geneAmount; chromosomeIndex++)
                {
                    if (((int)population[popIndex].Genes[chromosomeIndex]) == 1)
                    {
                        fitVal += ItemList[chromosomeIndex].Value;
                        combinedWeight += ItemList[chromosomeIndex].Weight;
                    }
                }
                if (combinedWeight > CAPACITY)
                    fitVal = 0;
                population[popIndex].Fitness = fitVal;
            }
        }
    }
}
