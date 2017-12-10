using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithms
{
    public class DigitSequenceGA : GABaseEngine
    {
        const int SEQUENCE_LENGTH = 11;
        const int DIGIT_LOW_RANGE = 0;
        const int DIGIT_HIGH_RANGE = 10;
        const int COST_GOAL = 0;

        public DigitSequenceGA(int populationSize, double keep, double mutation)
            : base(populationSize, keep, mutation) 
        {
            costGoal = COST_GOAL;
            goalType = EGoalType.Cost;
            chromosomeType = EChromosomeType.Int;
            geneAmount = SEQUENCE_LENGTH;
            lowRange = DIGIT_LOW_RANGE;
            highRange = DIGIT_HIGH_RANGE;
            population = ChromosomeFactory.CreateChromosomeArray(chromosomeType, populationSize);
        }

        //Fill population array with the given amount of chromosomes. Even chromosome creates its own genes from an integer range passed in
        public override void EncodeSolution()
        {
            for (int index = 0; index < populationSize; index++)
            {
                population[index] = ChromosomeFactory.CreateChromosome(chromosomeType, geneAmount);
                population[index].PopulateChromosome(random, lowRange, highRange);
            }
        }

        //Set a convergence requirement array to check each gene in each chromosome of the population
        //Each chromosomes array will be checked against the convergence array to calculate each genes cost(the distance between the expectation and the actual amount)
        //A total cost value (fitness) will be set for each chromosome
        //Fittest chromosome is stored in variable to allow elitism
        public override void FitnessFunction()
        {
            //Set convergence expectation
            int[] convergenceArray = new int[] { 0, 1, 2, 3, 4, 5, 4, 3, 2, 1, 0 };
            SetFitnessValues(convergenceArray);
            SortPopulation();
            SetFittestChromosome();
        }

        public void SetFitnessValues(int[] convergenceArray)
        {
            for (int popIndex = 0; popIndex < populationSize; popIndex++)
            {
                int fitVal = 0;
                for (int chromosomeIndex = 0; chromosomeIndex < geneAmount; chromosomeIndex++)
                {
                    int geneValue = (int)population[popIndex].Genes[chromosomeIndex];
                    int correctValue = convergenceArray[chromosomeIndex];
                    if (geneValue <= correctValue)
                        fitVal += correctValue - geneValue;
                    else
                        fitVal += geneValue - correctValue;
                }
                population[popIndex].Fitness = fitVal;
            }
        }
    }
}
