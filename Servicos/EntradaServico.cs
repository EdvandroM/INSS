using INSS.Interfaces;
using System;

namespace INSS.Servicos
{
    public class EntradaServico : IEntradaServico
    {
        private ICalculadorInss _calculadoraInss { get; }
        public EntradaServico()
        {
            _calculadoraInss = new CalculadoraInssServico();
        }

        public decimal CalcularInssParaAno(DateTime data, decimal salario) 
        {
            if (!(data > DateTime.MinValue && salario > 0))
                throw new ArgumentException("Necessário informar dados para cálculo");

            var descontoCalculado = _calculadoraInss.CalcularDesconto(data, salario);

            return descontoCalculado;
        }
    }
}
