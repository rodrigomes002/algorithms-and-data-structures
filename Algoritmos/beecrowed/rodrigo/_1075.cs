﻿namespace Algoritmos.beecrowed.rodrigo
{
    public class _1075
    {
        public static void RestoDois()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i=1; i<= 10000; i++)
            {
                if (i % n == 2)
                    Console.WriteLine(i);
            }
        }
    }
}
