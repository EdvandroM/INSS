using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace INSS.Helper
{
    public static class JsonHelper
    {
        public static T DeserializeObject<T>(string caminhoArquivo)
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(caminhoArquivo));
        }
    }
}
