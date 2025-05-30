using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Intro_C__backend.Models
{
    public class Disenadores : ISendRequest
    {
        [JsonPropertyName("id")] //<--Esto permite "Traducir" la propiedades del JSON  y del objeto para evitar conflicto
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("lastname")]
        public string Lastname { get; set; }
        
        [JsonPropertyName("description")]
        public string Description { get; set; }
        
        [JsonPropertyName("picture")]
        public string Picture { get; set; }

    }
}
