namespace algoritmos.beecrowed.rodrigo
{
    public static class _1072
    {
        public static void Intervalor2()
        {
            var n = int.Parse(Console.ReadLine()!);
            int dentro = 0, fora = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine()!);

                if (x >= 10 && x <= 20)
                    dentro++;
                else
                    fora++;
            }

            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
        }
    }
}

