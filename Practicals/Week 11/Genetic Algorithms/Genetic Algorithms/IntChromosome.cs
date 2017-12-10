using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithms
{
    public class IntChromosome : Chromosome
    {
        public IntChromosome(int geneAmount)
        {
            Genes = new int[geneAmount];
        }

        public override void PopulateChromosome(Random random, int lowRange, int highRange)
        {
            for (int index = 0; index < Genes.Count; index++)
                Genes[index] = random.Next(lowRange, highRange);
        }

        public override void MutateGene(Random random, int lowRange, int highRange)
        {
            int mutationIndex = random.Next(Genes.Count);
            int mutation = random.Next(lowRange, highRange);
            Genes[mutationIndex] = mutation;
        }
    }
}
