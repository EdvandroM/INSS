using Newtonsoft.Json;
using System.Collections.Generic;

namespace INSS.Modelo
{
    public class TabelaInss
    {
        [JsonProperty("ano-referencia")]
        public int AnoRef { get; set; }
        [JsonProperty("desconto-teto")]
        public decimal Teto { get; set; }
        [JsonProperty("salario-aliquota")]
        public IEnumerable<SalarioAliquota> ListAliquota { get; set; }
    }

    public class SalarioAliquota
    {
        [JsonProperty("faixa-inicial")]
        public decimal FaixaInicial { get; set; }
        [JsonProperty("faixa-final")]
        public decimal FaixaFinal { get; set; }
        [JsonProperty("aliquota")]
        public decimal Aliquota { get; set; }
    }
}
