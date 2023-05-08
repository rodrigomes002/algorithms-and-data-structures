namespace Algoritmos.beecrowed.rodrigo
{
    public class _1071
    {
        public static void SomaImparesConsecutivos()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine()) + 1;
            int soma = 0;
            for (int i = y; i < x; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}
