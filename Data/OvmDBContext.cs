using Data.Entities;
using Data.Initializers;
using System.Data.Entity;
//using Data.Entities.TimeOffs;

namespace Data
{
    public class OvmDbContext : DbContext
    {
        /*public OvmDbContext()
            : base("name=OvmDbContext")
        {
            Database.SetInitializer(new OvmDbDropCreateIfModelChanges());
        }*/

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Car> Car { get; set; }

        public virtual DbSet<Request> Request { get; set; }
    }
}
