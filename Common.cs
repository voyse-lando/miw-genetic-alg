﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miw_genetic_alg
{
    public class ArrayEqualityComparer : IEqualityComparer<byte[]>
    {
        public bool Equals(byte[] x, byte[] y)
        {
            if (x.Length != y.Length) return false;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] != y[i]) return false;
            }
            return true;
        }

        public int GetHashCode(byte[] obj)
        {
            int hash = 17;
            foreach (int item in obj)
            {
                hash = hash * 31 + item.GetHashCode();
            }
            return hash;
        }
    }

    public static class Common
    {
        private static Random random = new Random();

        public static Dictionary<byte[], double> CreateDecodeTable(double min, double max, int bitsPerParameter)
        {
            Dictionary<byte[], double> ret = new Dictionary<byte[], double>(new ArrayEqualityComparer());

            for (uint i = 0; i <= Math.Pow(2, bitsPerParameter) - 1; ++i)
            {
                byte[] key = new byte[bitsPerParameter];
                for (var b = 0; b < bitsPerParameter; ++b)
                {
                    key[bitsPerParameter - b - 1] = (byte)((i & (int)Math.Pow(2, b)) >> b);
                }

                ret[key] = min + i / (Math.Pow(2, bitsPerParameter) - 1) * (max - min);
            }
            return ret;
        }

        public static byte[][] CreatePopulation(int size, int parameters, int bitsPerParameter)
        {
            byte[][] pop = new byte[size][];

            for (int i = 0; i < size; ++i)
            {
                pop[i] = new byte[parameters * bitsPerParameter];
                for (int k = 0; k < parameters * bitsPerParameter; ++k)
                {
                    pop[i][k] = (byte)random.Next(2);
                }
            }

            return pop;
        }

        public static byte[] GetParameter(byte[] entity, int idx, int bitsPerParameter)
        {
            return entity.Take(new Range(idx * bitsPerParameter, (idx + 1) * bitsPerParameter)).ToArray();
        }

        public static byte[] TournamentSelect(
            byte[][] population,
            double[] fitness,
            int tournamentSize,
            Func<long[], double[], long> evaluator
        )
        {
            long[] tournament = [];
            for (var i = 0; i < tournamentSize; ++i)
            {
                long index = random.Next(population.Length);
                if (tournament.Contains(index)) --i;
                tournament = tournament.Append(index).ToArray();
            }

            long best = evaluator(tournament, fitness);
            return (byte[])population[best].Clone();
        }

        public static (byte[] child1, byte[] child2) Crossover(byte[] parent1, byte[] parent2)
        {
            var point = random.Next(parent1.Length);
            var left = new Range(0, point);
            var right = new Range(point, parent1.Length);

            byte[] child1 = [.. parent1.Take(left), .. parent2.Take(right)];
            byte[] child2 = [.. parent2.Take(left), .. parent1.Take(right)];

            return (child1, child2);
        }

        public static void MutateRandom(ref byte[] entity, int parameters, int bitsPerParameter)
        {
            var mutationIndex = random.Next(parameters * bitsPerParameter);
            entity[mutationIndex] = (byte)(entity[mutationIndex] ^ 1);
        }
    }
}
