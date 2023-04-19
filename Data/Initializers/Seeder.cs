using Data.Entities;

namespace Data.Initializers
{
    public static class Seeder
    {
        public static void Seed(OvmDbContext context)
        {
            //Here we're going to add different car models that would be displayed on the main page
            //Here we're going to add the different users that would be visible by the administrator role
            //Here we're going to add the different requests that would be visible by the administrator role

            context.SaveChanges();
        }
    }
}
