using Estudo_EntityFrameworkCore.Data.Interface;
using Estudo_EntityFrameworkCore.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudo_EntityFrameworkCore.Data.Repository
{
    public class UsuarioRepository : Repository<UsuarioDAO>, IUsuarioRepository
    {
        public UsuarioRepository(IgrejaDbContext context) : base(context)
        {
        }
    }
}
