using AutoMapper;
using Bistros.Core.Application.Interfaces;
using Bistros.Core.Application.Mapping;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bistros.Core.Application.Services
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));

            services.AddAutoMapper(opt =>
            {
                opt.AddProfiles(new List<Profile>
                {
                    new MappingProfile(),
                });
            });
        }
    }
}
