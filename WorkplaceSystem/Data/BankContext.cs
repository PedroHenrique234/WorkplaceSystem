using Microsoft.EntityFrameworkCore;
using WorkplaceSystem.Models;

namespace WorkplaceSystem.Data
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions<BankContext> options) : base(options) 
        {
        }

        public DbSet<ClientModel> Clients { get; set; }
        public DbSet<UseModel> Uses { get; set; }
    }
}
