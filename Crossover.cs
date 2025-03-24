using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miw_genetic_alg
{
    public static class Crossover
    {
        private static readonly Random random = new Random();

        public static (byte[] child1, byte[] child2) CreateCrossover(byte[] parent1, byte[] parent2)
        {
            var cut = random.Next(Constants.BitsPerEntity);

            byte[] child1 = new byte[Constants.BitsPerEntity];
            byte[] child2 = new byte[Constants.BitsPerEntity];

            for (int i = 0; i <= cut; ++i)
            {
                child1[i] = parent1[i];
                child2[i] = parent2[i];
            }
            for (int i = cut+1; i < Constants.BitsPerEntity; ++i)
            {
                child1[i] = parent2[i];
                child2[i] = parent1[i];
            }

            return ((byte[])child1.Clone(), (byte[])child2.Clone());
        }
    }
}
