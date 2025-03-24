using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miw_genetic_alg
{
    public static class Mutation
    {
        public static readonly Random random = new Random();
        public static void MutateRandom(ref byte[] entity)
        {
            var mutationIndex = random.Next(Constants.BitsPerEntity);
            entity[mutationIndex] = (byte)(entity[mutationIndex] ^ 1);
        }
    }
}
