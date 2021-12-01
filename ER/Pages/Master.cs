using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ER.Pages
{
    public class Master
    {
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Email { get; set; }
        [JsonPropertyName("img")]
        public string Image { get; set; }

        //public override string ToString() => JsonSerializer.Serialize<Master>(this);
    }
}
