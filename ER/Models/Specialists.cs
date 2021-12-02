using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ER.Models
{
    public class Specialists
    {
        public int Id { get; set; }
        [Display(Name = "Full Name")]
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Email { get; set; }
        public string Profession { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }
    }
}
