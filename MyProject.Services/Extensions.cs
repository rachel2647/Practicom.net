using Microsoft.Extensions.DependencyInjection;
using MyProject.Repositories;
using MyProject.Services.Interfaces;
using MyProject.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services
{
    public static class Extensions
    {
       public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Mapping));

            services.AddRepositories();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IChildrenService, ChildrenService>();

            return services;
        }
    }
}
