namespace Algoritmos.beecrowed
{
    public static class _1073
    {
        public static void QuadradoDePares()
        {
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    int quadrado = i * i;
                    Console.WriteLine($"{i}^2 = {quadrado}");
                }
            }
        }
    }
}
