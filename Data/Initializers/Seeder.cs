using Data.Entities;

namespace Data.Initializers
{
    public static class Seeder
    {
        public static void Seed(OvmDbContext context)
        {
            context.SaveChanges();
        }
    }
}
