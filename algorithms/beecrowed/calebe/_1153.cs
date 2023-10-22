using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms.beecrowed.calebe
{
    public class _1153
    {
        public static void FatorialSimples()
        {
            int N = int.Parse(Console.ReadLine()!);
            int cont = N - 1;

            for (int i = N; i >= 3; i--)
            {
                N *= cont;
                cont -= 1;
            }
            Console.Write(N);
        }
    }
}
