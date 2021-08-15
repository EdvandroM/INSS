using INSS.Modelo;

namespace INSS.Interfaces
{
    public interface ICalculadoraInssRepository
    {
        TabelaInss BuscarTabelaPorAno(int anoRef);
    }
}
