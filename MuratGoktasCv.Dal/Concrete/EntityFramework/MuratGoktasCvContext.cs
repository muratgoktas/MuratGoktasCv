using MuratGoktasCvPro.Entities;
using System.Data.Entity;


namespace MuratGoktasCv.Dal.Concrete.EntityFramework
{
    public class MuratGoktasCvContext : DbContext
    {
        public DbSet<People> People { get; set; }

    }
}
