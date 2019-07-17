using Estudo_EntityFrameworkCore.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudo_EntityFrameworkCore.Data
{
    public class IgrejaDbContext : DbContext
    {
        public IgrejaDbContext(DbContextOptions<IgrejaDbContext> options) : base(options)
        {

        }

        public DbSet<UsuarioDAO> Usuario { get; set; }
    }
}
