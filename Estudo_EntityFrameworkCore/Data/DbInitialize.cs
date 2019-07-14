using Estudo_EntityFrameworkCore.Data.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudo_EntityFrameworkCore.Data
{
    public class DbInitialize
    {

        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<IgrejaDbContext>();

                var jjonajaime = new User { Name = "JJonaJaime", Email = "JJonaJaime@jj.com" , IdUser = 1};

                context.Users.Add(jjonajaime);

                context.SaveChanges();
            }
        }
    }
}
