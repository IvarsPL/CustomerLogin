using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ER.Models
{
    public class Specialists
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Email { get; set; }
        public string Profession { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }
    }
}
