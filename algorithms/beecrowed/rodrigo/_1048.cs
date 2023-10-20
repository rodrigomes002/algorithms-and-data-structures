namespace algorithms.beecrowed.rodrigo
{
    public class _1048
    {
        public static void CalcularReajuste()
        {
            double salario = double.Parse(Console.ReadLine());
            double novoSalario, percentual, reajuste;

            if (salario <= 400)
                percentual = 15.0;
            else if (salario <= 800)
                percentual = 12.0;
            else if (salario <= 1200)
                percentual = 10.0;
            else if (salario <= 2000)
                percentual = 7.0;
            else
                percentual = 4;

            reajuste = salario * percentual / 100;
            novoSalario = salario + reajuste;

            Console.WriteLine("Novo salario: {0:F2}", novoSalario);
            Console.WriteLine("Reajuste ganho: {0:F2}", reajuste);
            Console.WriteLine("Em percentual: {0} %", percentual);
        }
    }
}
