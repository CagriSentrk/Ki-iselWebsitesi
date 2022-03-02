using System.Data.Entity;
namespace WebApplication16.Models.Siniflar
{
    public class context :DbContext

    {
        public DbSet<admin> admins { get; set; }
        public DbSet<Anasayfa> anasayfas{ get; set; }
        public DbSet <ikonlar> ikonlars{ get; set; }
    }
}