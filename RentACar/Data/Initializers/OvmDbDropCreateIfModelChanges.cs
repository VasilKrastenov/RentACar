﻿using Data;
using System.Data.Entity;

namespace RentACar.Data.Initializers
{
    public class OvmDbDropCreateIfModelChanges : DropCreateDatabaseIfModelChanges<OvmDbContext>
    {
        protected override void Seed(OvmDbContext context)
        {
            Seeder.Seed(context);

            base.Seed(context);
        }
    }
}
