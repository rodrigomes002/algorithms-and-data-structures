namespace algoritmos.beecrowed.rodrigo.refatoracao
{
    public class _1048
    {
        public static decimal CalcularReajusteSalario(decimal salario)
        {
            int porcentagem = Porcentagem(salario);
            decimal reajuste = salario * porcentagem / 100;

            return reajuste;
        }

        public static decimal CalcularNovoSalario(decimal salario)
        {
            decimal reajuste = CalcularReajusteSalario(salario);
            decimal novoSalario = salario + reajuste;

            return novoSalario;
        }

        public static int Porcentagem(decimal salario)
        {
            int porcentagem = 0;
            if (salario > 0 && salario <= 400)
                porcentagem = 15;

            if (salario >= 400.01M && salario <= 800)
                porcentagem = 12;

            if (salario >= 800.01M && salario <= 1200)
                porcentagem = 10;

            if (salario >= 1200.01M && salario <= 2000)
                porcentagem = 7;

            if (salario >= 2000)
                porcentagem = 4;

            return porcentagem;
        }
    }
}