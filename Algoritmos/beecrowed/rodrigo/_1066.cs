namespace Algoritmos.beecrowed.rodrigo
{
    public class _1066
    {
        public static void ParesImparesPositivosENegativos()
        {
            int quantidadePares = 0;
            int quantidadeImpares = 0;
            int quantidadePositivos = 0;
            int quantidadeNegativos = 0;

            for (int i = 0; i < 5; i++)
            {
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                    quantidadePares++;
                else
                    quantidadeImpares++;

                if (numero > 0)
                    quantidadePositivos++;

                if (numero < 0)
                    quantidadeNegativos++;

            }
            Console.WriteLine("{0} valor(es) par(es)", quantidadePares);
            Console.WriteLine("{0} valor(es) impar(es)", quantidadeImpares);
            Console.WriteLine("{0} valor(es) positivo(s)", quantidadePositivos);
            Console.WriteLine("{0} valor(es) negativo(s)", quantidadeNegativos);

        }
    }
}
