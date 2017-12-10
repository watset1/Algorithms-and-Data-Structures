using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithms
{
    public abstract class Chromosome
    {
        public IList Genes { get; set; }
        public int Fitness { get; set; }
        public int Rank { get; set; }
        public double CumulativeProb { get; set; }

        public abstract void PopulateChromosome(Random random, int lowRange, int highRange);

        public abstract void MutateGene(Random random, int lowRange, int highRange);
    }
}
