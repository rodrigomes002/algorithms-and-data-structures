namespace algorithms.beecrowed.rodrigo
{
    public class _1067
    {
        public static void Impares()
        {
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i <= numero; i++)
            {
                if (i % 2 > 0)
                    Console.WriteLine(i);
            }

        }
    }
}
