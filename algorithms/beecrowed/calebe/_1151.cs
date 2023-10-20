using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms.beecrowed.calebe
{
    public class _1151
    {
        public static void FibonacciFacil()
        {
            int N, prox, atual = 1, anterior = 0;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (i == N)
                    Console.WriteLine(anterior);
                else
                    Console.Write(anterior + " ");
                prox = anterior + atual;
                anterior = atual;
                atual = prox;
            }

        }
    }
}
