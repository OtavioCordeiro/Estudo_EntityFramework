using Estudo_EntityFrameworkCore.Data;
using Estudo_EntityFrameworkCore.Data.Interface;
using Estudo_EntityFrameworkCore.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace TesteXUnit
{
    public class UnitTest1
    {
        IgrejaDbContext _context;

        public UnitTest1()
        {
            string connectionString = @"Data Source=OTAVIO\SQLEXPRESS;Initial Catalog=IgrejaDB;Integrated Security=True";

            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkSqlServer()
                //.AddDbContext<IgrejaDbContext>(options => options.UseSqlServer(connectionString))
                .AddTransient<IUsuarioRepository, UsuarioRepository>()
                .BuildServiceProvider();

            var builder = new DbContextOptionsBuilder<IgrejaDbContext>();
            builder.UseSqlServer(connectionString).UseInternalServiceProvider(serviceProvider);

            _context = new IgrejaDbContext(builder.Options);
            //serviceProvider.AddTransient<IUsuarioRepository, UsuarioRepository>();
        }

        [Fact]
        public void Test1()
        {
            IUsuarioRepository repository = new UsuarioRepository(_context);

            var usuarios = repository.GetAll();
        }
    }
}
