using EdominarCRUDApp.Models.Configuration;
using EdominarCRUDApp.Models.db;
using Microsoft.EntityFrameworkCore;

namespace EdominarCRUDApp.Models
{
    public class EdominerCRUD : DbContext
    {
        public EdominerCRUD(DbContextOptions<EdominerCRUD> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Hobby> Hobbys { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            ApplyCongigurations(builder);
        }
        private static void ApplyCongigurations(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new StateConfiguration());
            builder.ApplyConfiguration(new HobbyConfiguration());
        }
    }
}
