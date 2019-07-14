using Estudo_EntityFrameworkCore.Data.Interface;
using Estudo_EntityFrameworkCore.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudo_EntityFrameworkCore.Data.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(IgrejaDbContext context) : base(context)
        {
        }
    }
}
