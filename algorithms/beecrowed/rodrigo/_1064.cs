namespace algorithms.beecrowed.rodrigo
{
    public class _1064
    {
        public static void PositivosEMedia()
        {
            int quantidadePositivos = 0;
            double somaPositivos = 0;

            for (int i = 0; i < 6; i++)
            {
                double valor = double.Parse(Console.ReadLine()!);

                if (valor > 0)
                {
                    quantidadePositivos++;
                    somaPositivos += valor;
                }
            }

            double mediaPositivos = somaPositivos / quantidadePositivos;

            Console.WriteLine($"{quantidadePositivos} valores positivos");
            Console.WriteLine(mediaPositivos.ToString("F1"));
        }
    }
}
