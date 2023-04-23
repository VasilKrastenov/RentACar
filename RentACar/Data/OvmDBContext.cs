using RentACar.Data.Initializers;
using RentACar.Models;
using System.Data.Entity;

namespace Data
{
    public class OvmDbContext : DbContext
    {
        public OvmDbContext()
            : base("name=OvmDbContext")
        {
            Database.SetInitializer(new OvmDbDropCreateIfModelChanges());
        }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Car> Car { get; set; }

        public virtual DbSet<Request> Request { get; set; }
    }
}
