using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithms
{
    public class KnapsackChromosome : Chromosome
    {
        public KnapsackChromosome(int geneAmount)
        {
            Genes = new Item[geneAmount];
        }

        public override void PopulateChromosome(Random random, int lowRange, int highRange)
        {
            throw new NotImplementedException();
        }

        public override void MutateGene(Random random, int lowRange, int highRange)
        {
            throw new NotImplementedException();
        }
    }
}
