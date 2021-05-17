using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SchoolApp.Application.Interfaces.Repository;
using SchoolApp.Persistence.Context;
using SchoolApp.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Persistence
{
    public static class ServiceRegistration
    {
        public static IConfiguration Configuration { get; private set; }

        public static void AddPersistenceServices(this IServiceCollection services)
        {
            //Database
            //services.AddDbContext<ApplicationDbContext>(op => op.UseSqlServer(Configuration.GetConnectionString("SqlServer")));

            //DI
            services.AddScoped<IStudentRepository, StudentRepository>();
        }
    }
}
