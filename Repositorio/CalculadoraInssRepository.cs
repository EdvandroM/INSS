using INSS.Helper;
using INSS.Interfaces;
using INSS.Modelo;
using System.Collections.Generic;
using System.Linq;

namespace INSS.Repositorio
{
    public class CalculadoraInssRepository : ICalculadoraInssRepository
    {
        private readonly IEnumerable<TabelaInss> ListTabel;
        public CalculadoraInssRepository()
        {
            ListTabel = JsonHelper.DeserializeObject<IEnumerable<TabelaInss>>($"{DiretorioHelper.GetExecutingDirectoryName()}\\TabelaINSS\\tabela-inss.json");
        }

        public TabelaInss BuscarTabelaPorAno(int anoRef)
        {
            return ListTabel.FirstOrDefault(x => x.AnoRef == anoRef);
        }
    }
}
