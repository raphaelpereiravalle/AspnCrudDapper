using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnCrudDapper.Entities
{
    public class JsonModel
    {
        public List<object> results;
        public object result;
        public List<Erro> Erros { get; set; }
        public bool Success { get; set; }
        public List<string> Msgs { get; set; }
        public string Message { get; set; }
    }

    public class Erro
    {
        public string key { get; set; }
        public List<string> Value { get; set; }
    }
}
