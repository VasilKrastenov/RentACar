using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Data.Entities;

namespace Data.Repository
{
    public class UserRepository
    {
        private readonly OvmDbContext _dbContext;

        public UserRepository(OvmDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
    }
}
