namespace Algoritmos.beecrowed
{
    public class _1051
    {
        public static void Imposto()
        {
            double renda = double.Parse(Console.ReadLine()!);
            double impostoAPagar, aliquota;

            if (renda <= 2000.00)
                aliquota = 0;
            else if (renda <= 3000.00)
                aliquota = 8;
            else if (renda <= 4500.00)
                aliquota = 18;
            else
                aliquota = 28;

            if (aliquota == 0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                impostoAPagar = renda * aliquota / 100;

                Console.WriteLine("R$ {0:F2}", impostoAPagar);
            }
        }
    }
}
