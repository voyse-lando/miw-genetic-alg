using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miw_genetic_alg
{
    public static class Tournament
    {
        private static readonly Random random = new Random();
        public static uint Size { get; set; } = 2;
        public static byte[] Select(byte[][] population, double[] fitness)
        {
            long[] tournament = [];
            for (var i = 0; i < Tournament.Size; ++i)
            {
                long index = random.Next(population.Length);
                if (tournament.Contains(index)) --i;
                tournament.Append(index);
            }

            long best = tournament.MaxBy(fitness.GetValue);
            return (byte[])population[best].Clone();
        }
    }
}
