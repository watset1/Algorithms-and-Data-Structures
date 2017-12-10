using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithms
{
    public class AlgebraGA : GABaseEngine
    {
        const int SEQUENCE_LENGTH = 4;
        const int DIGIT_LOW_RANGE = 1;
        const int DIGIT_HIGH_RANGE = 36;
        const int COST_GOAL = 0; //Convergeance fitness requirement
        const int ANSWER = 42;

        public AlgebraGA(int populationSize, double keep, double mutation)
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
                population[index] = new IntChromosome(geneAmount);
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
                int total = 0;
                total += (int)population[popIndex].Genes[0];
                total += (int)population[popIndex].Genes[1] * 2;
                total += (int)population[popIndex].Genes[2] * 3;
                total += (int)population[popIndex].Genes[3] * 4;

                if (total >= ANSWER)
                    fitVal = total - ANSWER;
                else
                    fitVal = ANSWER - total;

                population[popIndex].Fitness = fitVal;
            }
        }
    }
}
