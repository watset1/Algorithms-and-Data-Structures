using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithms
{
    public enum EChromosomeType{ Int, Knapsack }

    public static class ChromosomeFactory
    {
        public static Chromosome CreateChromosome(EChromosomeType type, int geneAmount)
        {
            Chromosome chromosome = null;
            switch (type)
            {
                case EChromosomeType.Int:
                    chromosome = new IntChromosome(geneAmount);
                    break;

                case EChromosomeType.Knapsack:
                    chromosome = new KnapsackChromosome(geneAmount);
                    break;
            }
            return chromosome;
        }

        public static Chromosome[] CreateChromosomeArray(EChromosomeType type, int populationSize)
        {
            Chromosome [] population = null;
            switch (type)
            {
                case EChromosomeType.Int:
                    population = new IntChromosome[populationSize];
                    break;

                case EChromosomeType.Knapsack:
                    population = new KnapsackChromosome[populationSize];
                    break;
            }
            return population;
        }
    }
}
