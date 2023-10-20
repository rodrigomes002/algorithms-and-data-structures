namespace algorithms.beecrowed.rodrigo
{
    public class _1060
    {
        public static void NumerosPositivos()
        {
            var numeros = new List<double>();
            int i = 1;
            while (i <= 6)
            {
                string numero = Console.ReadLine();
                if (numero != null)
                    numeros.Add(double.Parse(numero));
                i++;
            }

            int quantidade = 0;
            foreach (var numero in numeros)
            {
                if (numero >= 0)
                    quantidade++;
            }

            Console.WriteLine("{0} valores positivos", quantidade);
        }
    }
}
