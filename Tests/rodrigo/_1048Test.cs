using Algoritmos.beecrowed.rodrigo.refatoracao;

namespace Tests.rodrigo
{
    public class _1048Test
    {
        [Fact]
        public void Deve_Calcular_Reajuste_Salario_400()
        {
            var reajuste = _1048.CalcularReajusteSalario(400);

            Assert.Equal(60, reajuste);
        }

        [Fact]
        public void Deve_Calcular_Novo_Salario_400()
        {
            var novoSalario = _1048.CalcularNovoSalario(400);

            Assert.Equal(460, novoSalario);
        }


        [Fact]
        public void Deve_Calcular_Porcentagem_Salario_400()
        {
            var porcentagem = _1048.Porcentagem(400);

            Assert.Equal(15, porcentagem);

        }

    }
}
