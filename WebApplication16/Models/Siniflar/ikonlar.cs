using System.ComponentModel.DataAnnotations;

namespace WebApplication16.Models.Siniflar
{
    public class ikonlar
    {
        [Key]
        public int id { get; set; }
        public string ikonad { get; set; }
        public string link { get; set; }
    }
}