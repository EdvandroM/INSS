using INSS.Interfaces;
using INSS.Modelo;
using INSS.Repositorio;
using System;
using System.Linq;

namespace INSS.Servicos
{
    public class CalculadoraInssServico : ICalculadorInss
    {
        private ICalculadoraInssRepository _calculadoraInssRepository { get; }
        public CalculadoraInssServico()
        {
            _calculadoraInssRepository = new CalculadoraInssRepository();
        }

        public decimal CalcularDesconto(DateTime data, decimal salario)
        {
            var tabelaInss = _calculadoraInssRepository.BuscarTabelaPorAno(data.Year);

            if (tabelaInss == null)
                throw new ArgumentException($"Tabela INSS não configurada para ano ref. {data.Year}");

            var aliquotas = tabelaInss.ListAliquota;
            var aliquota = aliquotas.FirstOrDefault(x => x.FaixaInicial <= salario && salario <= x.FaixaFinal && salario > 0);
            var desconto = 0M;

            if (FaixaSalarialUsaTeto(aliquota))
                desconto = tabelaInss.Teto;
            else
                desconto = (salario * (aliquota.Aliquota / 100));

            return desconto;
        }
        private bool FaixaSalarialUsaTeto(SalarioAliquota aliquota)
        {
            return aliquota == null;
        }
    }
}
