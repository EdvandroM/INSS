using System;

namespace INSS.Interfaces
{
    public interface IEntradaServico
    {
        decimal CalcularInssParaAno(DateTime data, decimal salario);
    }
}
