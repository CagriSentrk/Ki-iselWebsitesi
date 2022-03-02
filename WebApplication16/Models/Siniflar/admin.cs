using System.ComponentModel.DataAnnotations;

namespace WebApplication16.Models.Siniflar
{
    public class admin
       
    {
        [Key]
        public int id { get; set; }
        public string kullaniciad { get; set; }
        public string sifre { get; set; }
    }
}