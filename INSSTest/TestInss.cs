using INSS.Interfaces;
using INSS.Servicos;
using System;
using Xunit;

namespace INSSTest
{
    public class TestInss
    {
        private string DataTest { get; } = "2012-01-01";
        [Fact]
        public void TestInicialized_Constructor()
        {
            //ACT
            IEntradaServico servico = new EntradaServico();

            //ASSERT
            Assert.NotNull(servico);
        }

        [Fact]
        public void Test_CalcularInssParaAno_Throw()
        {
            //ARRANGE
            IEntradaServico servico = new EntradaServico();

            //ASSERT
            Assert.Throws<ArgumentException>(() => servico.CalcularInssParaAno(DateTime.Parse(DataTest), 0));
        }

        [Fact]
        public void Test_CalcularInssParaAno_Return()
        {
            //ARRANGE
            IEntradaServico servico = new EntradaServico();

            //ACT
            var descontoTeste = servico.CalcularInssParaAno(DateTime.Parse(DataTest), 1500.02M);

            //ASSERT
            Assert.True(descontoTeste > 0);
        }

        [Fact]
        public void Test_CalcularInssParaAno_Teto_Return()
        {
            //ARRANGE
            IEntradaServico servico = new EntradaServico();

            //ACT
            var descontoTeste = servico.CalcularInssParaAno(DateTime.Parse(DataTest), 9999);

            //ASSERT
            Assert.True(descontoTeste > 0);
        }

        [Fact]
        public void Test_CalcularInssParaAno_Year_Throw()
        {
            //ARRANGE
            ICalculadorInss servico = new CalculadoraInssServico();

            //ASSERT
            Assert.Throws<ArgumentException>(() => servico.CalcularDesconto(DateTime.MinValue, 0));
        }
    }
}
