using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MinhaPrimeiraApi.Models
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Email{get; set;}
        [JsonIgnore]
        public string Senha {get; set; }
    }
}