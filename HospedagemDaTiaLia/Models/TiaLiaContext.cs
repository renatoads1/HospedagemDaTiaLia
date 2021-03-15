using HospedagemDaTiaLia.Models;
using Microsoft.EntityFrameworkCore;

namespace HospedagemDaTiaLia.Models
{
    class TiaLiaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            opt.UseSqlite("Data Source=tialia.db");
        }
        public DbSet<Hospede> Hospede { get; set; }
    }
}
