namespace algorithms.beecrowed.rodrigo
{
    public class _1065
    {
        public static void ParesEntreNumeros()
        {
            int quantidadePares = 0;

            for (int i = 0; i < 5; i++)
            {
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                    quantidadePares++;
            }
            Console.WriteLine("{0} valores pares", quantidadePares);
        }
    }
}
