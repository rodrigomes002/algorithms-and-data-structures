namespace algoritmos.beecrowed.rodrigo
{
    public class _1070
    {
        public static void ImparesConsecutivos()
        {
            int numero = int.Parse(Console.ReadLine()!);
            int count = 6;

            while (count > 0)
            {
                if (numero % 2 > 0)
                {
                    Console.WriteLine(numero);
                    count--;
                }
                numero++;
            }
        }
    }
}
