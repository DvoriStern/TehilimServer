using Common.Dtos;
using Microsoft.Extensions.DependencyInjection;
using Repository.Entity;
using Repository.Repositories;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {

            services.AddRepository();
            services.AddScoped(typeof(IService<ChaptersOfTehilimDto>), typeof(ChaptersOfTehilimService));
            services.AddScoped(typeof(IService<GroupDto>), typeof(Group));
            services.AddScoped(typeof(IService<NameForPrayerDto>), typeof(NameForPrayer));
            services.AddScoped(typeof(IService<RequestPrayerDto>), typeof(RequestPrayer));
            services.AddScoped(typeof(IService<SharingDto>), typeof(Sharing));
            services.AddScoped(typeof(IService<UserDto>), typeof(User));

            services.AddAutoMapper(typeof(MapperProfile));
            return services;

        }
    }
}
