using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithms
{
    public class ExampleGA : GABaseEngine
    {
        const int SEQUENCE_LENGTH = 5;
        const int DIGIT_LOW_RANGE = 0;
        const int DIGIT_HIGH_RANGE = 2;
        const int COST_GOAL = 0; //Convergeance fitness/cost requirement

        public ExampleGA(int populationSize, double keep, double mutation)
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

        public override void EncodeSolution()
        {
            for (int index = 0; index < populationSize; index++)
            {
                population[index] = ChromosomeFactory.CreateChromosome(EChromosomeType.Int, geneAmount);
                population[index].PopulateChromosome(random, lowRange, highRange);
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
                for (int chromosomeIndex = 0; chromosomeIndex < geneAmount; chromosomeIndex++)
                {
                    int geneValue = (int)population[popIndex].Genes[chromosomeIndex];
                    if (geneValue == 0)
                        fitVal++;
                }
                population[popIndex].Fitness = fitVal;
            }
        }
    }
}
