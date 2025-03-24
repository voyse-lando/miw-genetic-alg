using System;
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

    public static class Parameters
    {
        public static Dictionary<byte[], double> CreateDecodeTable(double min, double max, uint noBitsPerParam)
        {
            Dictionary<byte[], double> ret = new Dictionary<byte[], double>(new ArrayEqualityComparer());

            for (uint i = 0; i <= Math.Pow(2, noBitsPerParam) - 1; ++i)
            {
                byte[] key = new byte[noBitsPerParam];
                for (var b = 0; b < noBitsPerParam; ++b)
                {
                    key[noBitsPerParam - b - 1] = (byte)((i & (int)Math.Pow(2, b)) >> b);
                }

                ret[key] = min + i / (Math.Pow(2, noBitsPerParam) - 1) * (max - min);
            }
            return ret;
        }
    }
}
