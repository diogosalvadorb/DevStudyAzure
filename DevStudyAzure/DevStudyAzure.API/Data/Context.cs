using DevStudyAzure.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DevStudyAzure.API.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
