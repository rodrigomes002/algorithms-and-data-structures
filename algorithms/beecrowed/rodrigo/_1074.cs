namespace algorithms.beecrowed.rodrigo
{
    public static class _1074
    {
        public static void ParOuImpar()
        {
            int n = int.Parse(Console.ReadLine()!);
            var saida = new string[n];

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine()!);

                if (x % 2 == 0)
                    saida[i] += "EVEN ";
                else
                    saida[i] += "ODD ";

                if (x > 0)
                    saida[i] += "POSITIVE ";
                else if (x < 0)
                    saida[i] += "NEGATIVE ";
                else
                    saida[i] = "NULL";

            }

            foreach (string i in saida)
            {
                Console.WriteLine(i.Trim());
            }
        }
    }
}
