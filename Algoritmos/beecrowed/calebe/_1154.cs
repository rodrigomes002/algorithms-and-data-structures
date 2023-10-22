using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace algoritmos.beecrowed.calebe
{
    public class _1154
    {
        public static void Idades()
        {
            int idade = int.Parse(Console.ReadLine()!);
            int quant = 0;
            double soma = 0;

            while (idade > 0)
            {
                if (idade > 0)
                {
                    quant += 1;
                    soma += idade;
                }
                idade = int.Parse(Console.ReadLine()!);
            }
            
            double media = soma / quant;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
